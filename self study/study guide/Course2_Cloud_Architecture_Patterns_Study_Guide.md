# 📗 Study Guide: The Complete Cloud Computing Software Architecture Patterns

> A reading-friendly rewrite of Course 2 — the pattern catalog that builds on Course 1's foundations. Each pattern gets: **The Problem**, **The Pattern** (explained), a **Real-World Example**, and a **Quick Recap**. Extra comparison tables and "why this matters" notes are added to help the patterns actually stick — and to help you tell similar-sounding patterns apart (which is where most people get tripped up).

## 🕐 Suggested study schedule

| Part | Topic | Est. reading time |
|---|---|---|
| 1 | Introduction | 10 min |
| 2 | Scalability Patterns (5 patterns) | 45 min |
| 3 | Performance Patterns for Data-Intensive Systems (7 patterns) | 60 min |
| 4 | Software Extensibility Patterns (3 patterns) | 30 min |
| 5 | Reliability & Error Handling Patterns (4 patterns) | 40 min |
| 6 | Deployment & Production Testing Patterns (4 patterns) | 35 min |
| **Total** | | **~3.5 hours** |

---

## Part 1 — Introduction

### The Big Idea
Unlike classic OOP "design patterns" (Gang of Four, 1994 — Factory, Singleton, Strategy, etc.), which help organize code *inside* a single application written in an object-oriented language, this course teaches **software architecture patterns**: reusable solutions to problems that show up across large-scale, multi-service, cloud-hosted systems — regardless of what language or framework each service uses.

**Why these patterns generalize across totally different businesses:** a dating app, an online store, and an education platform have nothing in common *functionally* — but they face the *same* quality-attribute challenges (scaling to millions of users, handling failures gracefully, shipping new features safely). Since quality attributes (not features) are what architecture patterns address, the same toolkit applies everywhere.

### Core Concepts

**Cloud computing = the biggest "pattern" underlying everything else in this course.** It solves two fundamental problems:
1. **Instant access to near-infinite compute/storage/network** ("Infrastructure as a Service") — no more months of procurement before you can launch.
2. **Pay-as-you-go pricing** — removes the huge upfront capital barrier that used to block new companies from competing.

Beyond raw infrastructure, cloud providers also give you managed building blocks (databases, message brokers, load balancers, monitoring, Function-as-a-Service) — the same building blocks from Course 1 — ready to use in minutes.

**Two cloud-native reliability features worth knowing by name:**
- **Multi-region deployment** — run your system in multiple geographic regions → lower latency + better UX for far-away users.
- **Multi-zone (Availability Zone) deployment** — within one region, spread instances across isolated zones (separate power/network/cooling). If one zone loses power, your system keeps running from the others.

**Two real trade-offs of the cloud (things this course teaches you to mitigate):**
1. **You never own the infrastructure** → pay-as-you-go means your bill grows continuously as you scale, so **cost efficiency** becomes a first-class architectural concern alongside availability/performance.
2. **You don't control the underlying hardware** → it's shared, aging, and can die/freeze/disconnect at any time, and larger systems statistically hit more of these failures. This reframes the whole job: **architecting large-scale cloud systems is really about building reliable systems out of unreliable components** — which is exactly why Part 5 of this course exists.

### Quick Recap — Part 1
- Architecture patterns ≠ OOP design patterns: the former address cross-service, multi-language, quality-attribute problems; the latter address in-app code organization.
- Cloud computing = on-demand infrastructure + pay-as-you-go, plus ready-made building blocks.
- Trade-offs: you must actively manage cost, and you must architect for hardware/network unreliability as the default assumption, not the exception.

---

## Part 2 — Scalability Patterns

### Pattern: Load Balancing (Cloud Computing Use Cases)

**The Problem:** A single server can't absorb unlimited traffic — CPU, memory, or network capacity runs out, and just upgrading to a bigger VM only delays the inevitable.

**The Pattern:** Put a **dispatcher** between clients and a pool of **workers**; the dispatcher routes each incoming request to exactly one worker. Add more workers as load grows — this is horizontal scaling in its purest form. Works both for external client → backend traffic, and for internal service-to-service traffic in a microservices/multi-service architecture (each service scales independently behind its own load balancer).

**Two ways to implement it in the cloud:**
1. **Managed cloud load-balancer service** — a black-box, provider-managed service that itself runs as a redundant, auto-restarting group of instances so it never becomes a single point of failure.
2. **Message broker / distributed queue as a load balancer** — publishers send messages, a pool of consumer workers pulls from the queue and scales up/down with volume. ⚠️ Only fits when communication is **one-directional and asynchronous** (the publisher doesn't need/expect a response) — and it should stay strictly *internal*, unlike a load balancer which is fine for external traffic too.

**Routing algorithms (pick based on your backend's design):**

| Algorithm | How it works | Best for |
|---|---|---|
| **Round robin** | Routes sequentially to the next worker | Stateless apps where any server can handle any request |
| **Sticky session / session affinity** | Keeps routing a given client to the *same* server (via cookie or client IP) as long as it's healthy | Apps that hold session state server-side, or multi-request file uploads |
| **Least connections** | Routes to whichever server currently has the fewest open connections | Long-lived connections (SQL, LDAP, etc.) where round robin would unevenly overload some servers |

**Pairs naturally with auto-scaling:** hosts run lightweight monitoring agents (CPU/memory/network), and scaling policies tied to the load balancer add/remove servers dynamically — so your system grows during traffic spikes and shrinks (saving money) during quiet periods.

### Pattern: Pipes and Filters

**The Problem:** A single monolithic pipeline for multi-stage data processing forces every stage into the same language, the same hardware profile, and the same scaling factor — even though different stages have wildly different needs (one stage might need GPUs for ML, another needs high-bandwidth networking, another just needs cheap CPU).

**The Pattern:** Follow the "water through pipes, filtered at each stage" analogy. Data flows from a **data source**, through a series of independent **filters** (each doing exactly one transformation, unaware of the rest of the pipeline), to a **data sink**. The "pipes" connecting filters are typically message brokers/queues — and the *whole* payload doesn't even need to flow through the pipe; you can pass just a pointer/notification to data sitting in shared storage.

**Why splitting into filters pays off:**
- Each filter can be written in the best language for its job (Python for ML, C++ for CPU-heavy work, etc.).
- Each filter can run on the most cost-optimal hardware for its specific task.
- Each filter scales independently based on its own throughput needs.

**Real-world example (video upload pipeline):** split video into chunks → generate thumbnails → transcode each chunk to multiple resolutions/bitrates (enabling **adaptive streaming**) → encode to multiple formats. In parallel, a separate audio branch: transcribe speech-to-text → generate/translate captions. A third parallel branch: run copyright/content moderation checks. Each of these is an independent filter that can be swapped, scaled, or reimplemented without touching the others.

**Considerations:**
- Overhead/complexity grows if filters are too fine-grained — balance separation against maintenance cost.
- Each filter must be **stateless**, with all the info it needs passed in as input.
- ❌ Bad fit when the *entire* pipeline needs to succeed or fail as a single **transaction** — distributed transactions across independent components are notoriously hard and inefficient to roll back.

### Pattern: Scatter-Gather

**The Problem:** Sometimes you need an answer that's assembled from *many* independent sources at once — not routed to just one worker like load balancing.

**The Pattern:** A **dispatcher** sends the *same* request to **all** workers in parallel (not just one, unlike load balancing); an **aggregator** (which may be the same service or a separate one) collects and combines their responses into a single reply. Unlike load-balancing workers (identical, interchangeable), scatter-gather workers are typically *different* — different data subsets, different internal services, or even different external companies.

**3 representative use cases:**
1. **Internal instances holding different data slices** — e.g., a search query scattered to workers who each search their own subset of documents/images, then results are ranked and merged.
2. **Internal but different services** — each contributing a different type of information to a combined response.
3. **External services owned by other companies** — e.g., requesting quotes from many hotel partners for the same dates, then returning a merged, sorted list to the user.

**Key property:** the requester never knows (or needs to know) how many workers were queried, or whether they're internal or external — this uniformity is what makes the pattern so scalable.

**Considerations:**
- **Cap the wait time** — set a maximum time the aggregator will wait for worker responses; if some are late/unreachable, proceed with whatever you have rather than blocking forever.
- **Decouple dispatcher from workers** via a message broker (pub/sub) instead of the dispatcher needing to know exactly which/how many workers exist.
- **For long-running results** (deep analysis/big reports that take minutes/hours instead of milliseconds): split dispatcher and aggregator into separate services, generate a **tracking ID** immediately returned to the user, have each worker report back tagged with that ID, and let the aggregator assemble results asynchronously (client polls or gets notified when ready).

### Pattern: Execution Orchestrator (for Microservices)

**The Problem:** In a monolith, a multi-step business flow is just a sequence of method calls. Once you split into stateless, decoupled microservices, how do you run a multi-step flow (e.g., user registration touching several services) reliably?

**The Pattern:** Introduce a dedicated **Orchestrator service** — like a conductor of an orchestra: it doesn't play any instrument (perform business logic) itself, but directs each microservice to act in the right order (sequential where required, parallel where possible), and owns error handling, retries, and tracking flow state until completion.

**Real-world example (video-on-demand signup flow):** orchestrator → user service (validate username/password) → payment service (authorize card) → location service (region-lock content) → recommendation service (seed initial recommendations) → email service (send confirmation). Adding a new step (e.g., "let users create a public profile") only requires touching the orchestrator + relevant new service — everything else is untouched.

**Failure & recovery:**
- If a step fails (e.g., duplicate username), the orchestrator returns the error to the user and can resume once corrected.
- If a *downstream* service call times out, the orchestrator can retry (load balancer will route to a healthy instance).
- Because the orchestrator owns the whole flow, **debugging is easy** — its logs are a single source of truth for the entire transaction.
- If the **orchestrator instance itself dies** mid-flow, a retried request may hit a fresh instance with no memory of prior progress. Fix: the orchestrator persists flow **state in its own database**, so any instance can pick up where a dead one left off.

**⚠️ Key anti-pattern to avoid:** letting business logic creep into the orchestrator. Some logic there is sometimes unavoidable (for functionality too small to deserve its own service), but if it grows unchecked, the orchestrator becomes a monolith that just happens to talk to microservices.

### Pattern: Choreography (for Microservices)

**The Problem:** The orchestrator pattern solves multi-service flows, but at a cost: the orchestrator is **tightly coupled to every service it calls**. If Services A, B, and a brand-new Service C are all changing simultaneously, all their teams now have to coordinate around the shared orchestrator — recreating the very cross-team coordination overhead microservices were meant to eliminate. This trap is called the **distributed monolith anti-pattern**: all the downsides of a monolith *and* all the downsides of microservices, with none of the benefits.

**The Pattern:** Remove the smart central orchestrator entirely and replace it with a "dumb" **message broker**. Each service subscribes only to the events it cares about, processes them, and emits new events — like dancers in a choreographed routine, each following their own cues without a conductor.

**Real-world example (job search sign-up flow):** candidate service stores the new profile → emits event → triggers (in parallel) an email-confirmation function AND a skills-parser service → skills parser emits another event → triggers a job-search service → results emitted as another event → consumed by candidate service (stores results) and email service (sends digest, if opted in). No central coordinator anywhere.

**Trade-offs vs. Orchestration:**

| | Orchestration | Choreography |
|---|---|---|
| Coupling | Orchestrator tightly coupled to all services | Fully decoupled — services only know event topics |
| Ease of adding services | Requires editing the orchestrator | Just subscribe to relevant events, zero changes elsewhere |
| Best for | Complex flows, few services, need for tight control/visibility | Simple flows, many independently-evolving services |
| Debuggability | Easy — one central log to trace | **Hard** — asynchronous, distributed, no single trace point |
| Fault tolerance for temporary outages | Handled by orchestrator retries | Handled naturally — messages just wait in the broker |
| Cost (with Function-as-a-Service) | N/A | Can be very cheap — functions run only when an event fires |

### Quick Recap — Part 2
- **Load balancing**: one request → one worker; round robin / sticky session / least connections depending on statefulness and connection duration.
- **Pipes and filters**: chain of independent, stateless, single-purpose stages — freedom of language/hardware/scaling per stage, but a poor fit for cross-stage transactions.
- **Scatter-gather**: one request → *all* workers in parallel, aggregated into one response; cap wait time, decouple via broker, use tracking IDs for long jobs.
- **Orchestration**: central conductor manages a multi-step flow — easy to debug, but tightly couples all involved services (watch for business logic creep).
- **Choreography**: decentralized, event-driven flow — loosely coupled and scalable, but much harder to trace/debug when things go wrong.

---

## Part 3 — Performance Patterns for Data-Intensive Systems

### Pattern: MapReduce

**The Problem:** Processing truly massive datasets (billions of files, petabytes of data) means the challenge isn't the computation logic itself — it's distributing data and computation across hundreds/thousands of machines, scheduling execution, handling failures, and aggregating results. Reinventing this infrastructure for every big-data job is enormous overhead.

**The Pattern (programming model):** Express *any* computation as two functions:
- **Map** — takes an input key-value pair, emits a new set of intermediate key-value pairs.
- **Reduce** — takes one intermediate key + all its associated values, combines them into a smaller (often single) result.

*Classic example — word count:* `map` emits `(word, 1)` for every word in every file; the framework shuffles/groups all pairs by key (word); `reduce` sums up the 1's per word to get total occurrence counts.

**Architecture (2 components):**
- **Master** — plans/coordinates the whole job; splits input into chunks, assigns Map tasks to workers, later assigns Reduce tasks once intermediate data is partitioned and ready.
- **Worker pool** — potentially hundreds/thousands of machines running Map or Reduce tasks in parallel, fully independent of each other, so they never block waiting for siblings to finish (a Reduce worker can start as soon as at least one relevant Map worker is done).

**Failure handling:**
- Master pings workers periodically; unresponsive workers are marked failed and their task is rescheduled elsewhere (a failed Map worker's failure is also communicated to Reduce workers so they know where to re-fetch data from).
- Master failure (rarer, but a real single point of failure since there's only one): mitigated by either restarting the whole computation from scratch (fine for deterministic jobs — you just lose time), periodic snapshotting of scheduling state for fast master recovery, or a hot-standby shadow master that stays in sync and can take over instantly.

**Why it's a great fit for the cloud:**
1. Near-instant access to as many machines as needed for a huge batch job.
2. MapReduce is inherently a **batch** model (run on-demand or on a schedule) — so you only pay for compute *while the job runs*, not for maintaining thousands of idle machines. Storage (which you always pay for) is generally far cheaper than compute.

**In practice:** you rarely implement MapReduce yourself — you use an existing open-source (e.g., Hadoop-style) or cloud-provider-managed implementation, and just supply your data model, map/reduce functions, and tuning parameters.

### Pattern: The Saga Pattern

**The Problem:** One core microservices best practice is "one database per service" — but this means you lose **ACID transactions that span multiple services**. If a multi-step business transaction touches Services A, B, and C, each with its own database, how do you keep data consistent if one step fails partway through?

**The Pattern:** Model the transaction as a **sequence of local operations**, one per service. If a step succeeds, move to the next. If a step **fails**, run **compensating operations** that reverse the effects of the *already-completed* prior steps (a kind of manual rollback across services) — then either abort the transaction entirely or retry, depending on the situation.

**Two ways to implement Saga** (built on patterns you already know):
- **Orchestration-based Saga** — an orchestrator calls services in sequence, waits for each response, and decides whether to proceed or trigger compensating actions on failure.
- **Choreography-based Saga** — services communicate via a message broker; each service either emits the "success" event that triggers the next step, or a "failure/compensation" event that triggers rollback logic in the prior service.

**Real-world example (event ticketing system)** — business requirements: no scalping, must charge the customer, and never sell the same seat twice. Orchestrated flow: Order service (reserve the seat tentatively, block double-booking) → Security service (validate the user isn't blacklisted) → Payment service (authorize the charge) → Ticket-reservation service (finalize the seat — this is the **pivot operation**: once this succeeds, the rest of the flow always completes forward) → Order service (mark purchase complete) → Email service (send confirmation). If Payment fails, compensate by deleting the pending order. If Ticket Reservation fails (someone beat you to the seat), compensate by both releasing the pending card authorization *and* deleting the order.

**Key term — Pivot operation:** the point of no return in a Saga — once it succeeds, the rest of the flow is guaranteed to move forward (only compensations happen *before* the pivot, never after).

### Pattern: Transactional Outbox

**The Problem:** A service often needs to (1) update its database AND (2) publish an event to a message broker, as a result of a single business action. But updating a database and publishing to a broker is **not atomic** — there's no cross-system transaction between the two. If the service crashes between steps, you either lose the event (DB updated, nobody told) or lose the update (event published, but the DB write never happened) — either way, the rest of the distributed system silently drifts out of sync. This exact assumption ("DB update + event emit happens atomically") is quietly baked into the Saga pattern and others — so this gap needs a real fix.

**The Pattern:** Add an **Outbox table** to the service's own database. Instead of publishing directly to the broker, the service writes the business-logic update *and* a new row in the Outbox table **within the same database transaction** — so both happen or neither does, guaranteed by the database's own ACID support. A separate **message relay / forwarder service** watches the Outbox table, picks up new rows, publishes them to the message broker, then marks them sent (or deletes them).

**3 problems this pattern needs to additionally solve, and their fixes:**

1. **Duplicate events** (if the relay crashes right after publishing but before marking a row "sent," it may re-send it — "at-least-once delivery"). Often harmless for **idempotent** consumers (e.g., overwriting a lookup record with the same value twice is harmless); for non-idempotent consumers, attach a unique message ID so consumers can detect and discard duplicates they've already processed.
2. **No transaction support in the underlying database** (e.g., a NoSQL document store that can't atomically span multiple collections). Fix: piggyback the "message to send" as an extra field/attribute on the *same* document you're already atomically updating (single-document writes are typically still atomic even in NoSQL) — the relay periodically scans for documents with a pending-message field, sends it, then clears the field.
3. **Event ordering** (e.g., "user signed up" then seconds later "user cancelled" — order matters!). Fix: assign each Outbox row a strictly increasing sequence ID, so the relay always processes/publishes rows in the correct order.

### Pattern: Materialized View

**The Problem:** Storing data efficiently (normalized tables, joins) is great for storage cost — but expensive, complex queries (multi-table joins + aggregations) run repeatedly against that same data cause two problems: **high latency** (bad UX) and **high recurring compute cost** (you pay per query in the cloud, and running the same expensive query over and over wastes money).

**The Pattern:** Precompute and store the *result* of a specific (usually complex/frequent) query in a separate **read-only table** — the materialized view. Future requests read directly from this pre-built table instead of re-running the expensive original query. Whenever the underlying base data changes, the view is regenerated either immediately or on a fixed schedule, depending on how fresh it needs to be.

**Real-world example (online course platform):** instead of running a live `JOIN courses + reviews, GROUP BY course, AVG(rating), ORDER BY rating` every time a student loads the "top courses" page, precompute that result into a materialized view (either one general view, or one dedicated view per topic/category for maximum speed).

**Considerations:**
- **Trade-off: space for performance.** Extra storage cost for the materialized table — be selective about which queries are worth optimizing this way.
- **Where to store it:**
  - *Same database as the source tables* — convenient if your database natively supports materialized views with automatic, efficient (delta-based, not full-regeneration) refresh. You can also throttle refresh frequency if you don't need up-to-the-second freshness.
  - *Separate, read-optimized database* (e.g., an in-memory cache) — faster reads, and since it's always reconstructible from the source data, you don't need to worry about backup/redundancy for it. Trade-off: you now have to build and maintain the syncing logic yourself.

### Pattern: CQRS (Command Query Responsibility Segregation)

**The Big Idea:** Materialized View optimizes *specific queries*. CQRS takes the same idea and applies it *system-wide*: split your **entire read path from your entire write path** into separate services/databases, each independently optimized for its own workload.

**Core Concepts**

- **Command** = any operation that mutates data (create/update/delete).
- **Query** = any operation that only reads data.
- Instead of one shared database serving both, CQRS gives you:
  - A **Command service + Command database**, optimized purely for writes — this is where all business validation, permission checks, and write-path complexity live.
  - A **Query service + Query database**, kept simple, fast, and read-optimized (potentially even a different database *technology* entirely, chosen purely for query speed).

**Why this is powerful:**
- You can pick the *ideal* data model/technology independently for writes vs. reads — impossible with a single shared database that has to compromise between both workloads.
- Independent scaling — scale write-side instances/DB separate from read-side instances/DB, based on actual demand for each.
- Independent development/deployment — a Command-service change doesn't force retesting or redeploying the Query side (and vice versa), as long as the sync contract doesn't change.

**Keeping the two sides in sync:** every time the Command side accepts a write, it needs to propagate that change to the Query side. Two common implementations:
1. **Message broker in between** — Command service publishes an event on every write; Query service subscribes and updates its own store. (Note: guaranteeing this publish is *reliable* is exactly what the **Transactional Outbox** pattern solves — CQRS and Transactional Outbox are commonly used together.)
2. **Function-as-a-Service watcher** — a cloud function triggers only when the Command database changes, reads the delta, and updates the Query database. Costs nothing when there are no writes.

**⚠️ Key trade-off:** CQRS implementations generally only guarantee **eventual consistency** between the write and read sides (there's a small lag before a write becomes visible on the read side). Fine for most use cases — but if your use case genuinely needs *strict* consistency, CQRS is the wrong tool. It also adds real overhead: two databases, two services, and a sync mechanism to build, deploy, and maintain — only worth it if the performance gain outweighs that cost.

### Pattern: CQRS + Materialized View (combined)

**The Big Idea:** These two patterns solve overlapping but distinct problems, and combining them is extremely common and powerful.

**Core Concepts**
- **CQRS** solves the general architectural split between reads and writes (which services/databases handle what).
- **Materialized View** solves the specific problem of pre-computing a ready-to-query result — including, critically, **joining data that now lives in separate databases** because of microservices/CQRS.

**Real-world example (online store):** a "Product" command/data source and a "Review" command/data source live in separate services/databases (normal in microservices). A dedicated **Product Search service** subscribes to change events from both, and maintains its own materialized view (a pre-joined, ready-to-query read store combining product info + review/rating data). Now search queries never need to call two separate services live and join data on the fly — one fast read against one pre-built view.

This combo is exactly how CQRS typically gets implemented in a microservices world: the "Query side" of CQRS *is* a materialized view, often assembled from multiple upstream services' events.

### Pattern: Event Sourcing

**The Problem:** Standard databases store only the **current state** of an entity, overwriting the old value on every update — so you permanently lose the history of *how* you got there. That's a problem whenever you need an audit trail, need to reconstruct past states, or want to detect patterns across a sequence of changes.

**The Pattern:** Instead of storing and updating current state, store an **append-only, immutable log of events** — each event representing a fact or a delta/change, never modified after being written. To get the current state of an entity, **replay** all its events from the beginning (or from the last snapshot — see below).

**Real-world example (bank account):** instead of storing "current balance," store every individual transaction (deposit/withdrawal) as an event. Replaying all transactions from account opening always gives you the current balance — but you *also* retain a full audit trail for reporting, fraud-pattern detection, and personalized recommendations, none of which are possible if you only ever stored the running balance.

**Two ways to store events:**

| Storage | Strength | Weakness |
|---|---|---|
| **Database** (each event as a row) | Easy to run rich queries/analytics across the whole event set (e.g., "how many new orders on date X") | — |
| **Message broker** | Optimized for very high event volume, naturally preserves per-entity ordering | Harder to run complex ad-hoc queries directly against the event stream |

**A nice side benefit — write performance:** with a traditional mutable "current state" table, heavy concurrent writes to the same record cause lock contention and slow everyone down (readers included). With event sourcing, every write is just an **append-only** operation — no locking, no contention, much faster under write-heavy load (e.g., an inventory-count table hammered by simultaneous purchases/returns).

**Making replay efficient (2 strategies):**
1. **Snapshots** — periodically save a point-in-time summary (e.g., monthly account-balance snapshot) so you only need to replay events *since* the last snapshot, not from the beginning of time.
2. **Combine with CQRS** — separate the "append events" (write/command) side from a read-optimized "current state" service/database (even in-memory, for max speed) that stays updated as new events arrive (via direct subscription to the event log/broker).

**Event Sourcing + CQRS combined** = one of the most popular pairings in the industry: you get full audit history *and* fast, efficient reads — at the cost of only eventual consistency between the event log and the derived read state.

### Quick Recap — Part 3
- **MapReduce**: standardized map + reduce programming model + master/worker architecture → parallelize huge batch computations across the cloud, pay only while running.
- **Saga**: replace cross-service ACID transactions with a sequence of local operations + compensating operations on failure; implement via orchestration or choreography; "pivot operation" = point of no return.
- **Transactional Outbox**: guarantee "DB update + event publish" happens atomically via an Outbox table in the same DB transaction + a relay service; solves duplicate events, non-transactional DBs, and ordering.
- **Materialized View**: precompute/cache a specific expensive query's result in a dedicated read table — trade storage for speed/cost.
- **CQRS**: split the *entire* system into a write-optimized Command path and a read-optimized Query path, kept in sync (often via Transactional Outbox) — eventual consistency, added complexity, big performance win.
- **CQRS + Materialized View**: the natural combo — the Query side of CQRS is usually implemented as a materialized view assembled from multiple upstream event sources.
- **Event Sourcing**: store an immutable append-only log of events instead of mutable current state; replay (with snapshots) to reconstruct state; pairs beautifully with CQRS for audit history + fast reads.

---

## Part 4 — Software Extensibility Architecture Patterns

### Pattern: Sidecar & Ambassador

**The Problem:** Beyond each service's core business logic, almost every service also needs the *same* set of cross-cutting capabilities: emitting metrics, structured logging, service-discovery lookups, dynamic config reloading, etc. A shared library seems like the obvious fix — until you remember that in a real microservices org, different teams use *different languages* (Java, Python, Go...), so a single shared library can't be reused everywhere, and reimplementing it per-language risks inconsistent behavior/bugs across versions. Making each cross-cutting concern its own full network service, meanwhile, feels like overkill and adds network hops.

**The Pattern:** Run the shared functionality as a **separate process/container on the *same host*** as the main application — like a motorcycle **sidecar**: physically attached, but isolated, sharing the same "ride." Because it's co-located, communication with the main app is extremely fast (no real network hop) and it shares the same host resources (filesystem, CPU, memory) — so it can, for example, tail the app's log files or read/update its config directly, with zero network calls.

**Why this beats a shared library:** you implement the sidecar's logic **once**, in any language, and reuse the *same compiled artifact* (not reimplemented per-language) across every service on every host, regardless of what language that service itself is written in. Updates to shared cross-cutting behavior also don't require the app team to retest their business logic.

**Special case — the Ambassador pattern:** an Ambassador is a sidecar specifically dedicated to handling **outbound network communication** on behalf of the main app — essentially a local proxy. It absorbs all the messy networking concerns (retries, connection handling, auth, protocol specifics) out of the app's codebase, and because *all* traffic flows through it, it becomes a natural place to implement **distributed tracing** across services.

### Pattern: Anti-Corruption Adapter

**The Problem — two common scenarios:**
1. **Migration scenario:** you're incrementally migrating a decade-old monolith to microservices. Until the old system is fully gone, your shiny new services still need to talk to the legacy system's old protocols, APIs, and data models — which risks "corrupting" (leaking legacy patterns/complexity into) your new, clean codebase.
2. **Permanent legacy coexistence scenario:** sometimes you *never* fully retire an old system (e.g., a legacy B2B banking platform your new B2C product still depends on for infrastructure that's too costly/risky to rebuild) — but you still don't want that legacy complexity bleeding into your modern system either.

**The Pattern:** Insert a dedicated **Anti-Corruption Adapter service** between the old and new systems. The new system talks to the adapter using only *modern* models/APIs/tech, as if the legacy system were just another clean part of the new architecture. The adapter performs all translation and forwards requests to (or from) the legacy system.

**Considerations:**
- The adapter is a real service with real needs — it must be developed, tested, deployed, and made scalable like anything else (or it becomes a bottleneck).
- Translation between different data models always adds some **latency**.
- Running it continuously costs money in the cloud — if it's used infrequently, consider deploying it as a **Function-as-a-Service** so you only pay when it's actually invoked.

### Pattern: Backends for Frontends (BFF)

**The Problem:** A single, shared backend serving *every* frontend (web desktop, web mobile, native iOS, native Android, and eventually smartwatches/TVs/consoles...) grows into a bloated, complex service trying to satisfy incompatible needs (different screen sizes, different battery/bandwidth constraints, different input methods like camera scanning). Organizationally, this also forces every frontend team to coordinate with a single backend team for every feature, and pushes backend engineers toward a lowest-common-denominator API that under-serves every frontend rather than optimizing for any of them.

**The Pattern:** Split the monolithic backend into **multiple, dedicated backend services — one per frontend type**. Each BFF contains only the logic/data relevant to its specific frontend, making each one smaller, lighter, and purpose-optimized. Organizationally, this lets you form focused full-stack teams per frontend/backend pair, so e.g. the iOS team can ship end-to-end features without waiting on another team.

**Considerations:**
- **Shared logic problem:** login/signup/checkout logic is often needed by every frontend, so splitting backends risks duplicating that logic. A small, rarely-changing chunk of shared logic can live in a shared library, but for anything more substantial, better to extract it as its own **separate, clearly-owned service** than as a shared library (shared libraries create tight coupling and ownership ambiguity across teams).
- **Granularity decision:** how many BFFs do you actually need — one per specific device, or one per broader category (e.g., "all mobile" vs. "all desktop")? Decide based on how *meaningfully different* the experiences/feature sets actually are; don't split further than the real differences justify.
- **Cloud implementation tip:** use cloud load balancing to route requests to the right BFF based on path, headers (e.g., `User-Agent`), or other request attributes — and right-size each BFF's hardware independently (e.g., beefier compute for a mobile BFF doing more server-side work).

### Quick Recap — Part 4
- **Sidecar**: co-located companion process for cross-cutting concerns — write once, reuse across any language, low-latency local communication.
- **Ambassador**: a sidecar specialized for outbound networking — offloads retries/auth/protocol handling and enables easy distributed tracing.
- **Anti-Corruption Adapter**: an isolating translation layer between old and new systems — used during migrations or for permanent legacy coexistence.
- **Backends for Frontends**: one dedicated backend per frontend type — smaller, faster, more focused, better team autonomy, but watch for shared-logic duplication.

---

## Part 5 — Reliability, Error Handling and Recovery Patterns

### Pattern: Throttling and Rate Limiting

**The Problem — two flavors:**
1. **Resource overuse from your own consumers:** a client suddenly bombards your API with requests, either overwhelming your servers (crashing them, breaching your SLA) or triggering expensive auto-scaling that blows your budget — whether malicious or accidental.
2. **Your own overuse of external resources:** your system calling third-party APIs or cloud resources at a rate that accidentally blows past your intended budget.

**The Pattern:** Cap the number of requests (or bandwidth) allowed within a time window (per second/minute/day/etc.).
- **Server-side throttling** — you (the provider) protect yourself from over-consumption by your clients.
- **Client-side throttling** — you (the consumer) protect yourself from overspending on services you call.

**Strategies for what to do once a client exceeds their limit:**

| Strategy | Description | Good fit |
|---|---|---|
| **Reject** | Return an error immediately (HTTP `429 Too Many Requests`) | Real-time use cases like stock-price lookups, where a stale-but-fast reject is fine |
| **Queue** | Buffer excess requests and process them later, once capacity frees up (FIFO) | Use cases where delayed processing is acceptable, e.g. throttling trade frequency without outright rejecting trades |
| **Degrade service** | Keep serving the client, but at reduced quality (e.g., lower video/audio bitrate) instead of an outright block | Streaming platforms — throttle bandwidth without denying access entirely |
| **Combine strategies** | E.g., queue up to a daily cap, then start rejecting | Prevents the queue itself from becoming overloaded |

**Key design decision — scope of the limit:**
- **Per-API / global limit** — simple to guarantee you never exceed overall system capacity/budget, but one aggressive client can unfairly starve everyone else.
- **Per-client limit** — guarantees fairness and isolation between clients, but makes it much harder to bound your *total* aggregate load/cost across all clients.

### Pattern: Retry

**The Big Idea:** Many failures in a distributed cloud system (timeouts, transient crashes, brief network blips) are **short-lived and self-recovering** — so simply retrying the failed request is often enough.

**Core Concepts — key considerations that make Retry non-trivial in practice:**

1. **Add delay between retries** — without any delay, a brief partial outage (e.g., 2 of 10 instances down) can trigger a **retry storm**: all callers immediately re-hit the remaining healthy instances, overloading *them* too, causing a cascading failure across the whole service.
   - **Fixed delay** — same wait every time (simple, but can be suboptimal).
   - **Incremental (linear) backoff** — increase the delay by a fixed amount each retry.
   - **Exponential backoff** — double (or otherwise exponentially increase) the delay each retry — the most aggressive/safe option for services that may need real recovery time.

2. **Add jitter (randomization)** to the delay — otherwise, many callers that all detected the same failure at the same instant will retry in near-perfect synchronization, hammering the healthy remaining instances with a synchronized traffic spike. A small random offset spreads retries out over time.

3. **Time-box the total retry duration/count** — if a call still hasn't succeeded after a reasonable ceiling (e.g., ~1 second, or N attempts), stop retrying, surface a clear error to the user, and **alert on-call engineers**, since this is no longer a "hide it from the user" transient blip.

4. **Only retry idempotent operations** — retrying a non-idempotent call (like "charge the user") risks double effects (e.g., double-billing) if you can't distinguish "the original request never arrived" from "it arrived, succeeded, but the confirmation got lost in the network."

5. **Where to implement retry logic** — either as a shared library/module reused across services (many off-the-shelf implementations exist), or offloaded entirely from application code into a co-located **Ambassador sidecar**, so the app only ever sees a final success or failure.

### Pattern: Circuit Breaker

**The Big Idea:** Retry is an **optimistic** pattern — it assumes a failed call will probably succeed if you just try again. Circuit Breaker is a **pessimistic** pattern for a different class of failures: ones that are **severe and durable**, not brief blips — where retrying is pointless and just wastes resources while making the struggling downstream service's recovery harder.

**Core Concepts — the analogy:** like an electrical circuit breaker, when there's a "power surge" (error spike), it "opens the circuit," cutting off calls entirely rather than letting them keep flowing into a struggling system.

**3 states:**

| State | Behavior |
|---|---|
| **Closed** | Normal operation — requests pass through; the breaker tracks the recent success/failure rate |
| **Open** | Failure rate crossed a threshold — requests are stopped immediately (fast error/exception to the caller), *without* even attempting the network call — saving time, CPU, and network resources |
| **Half-open** | After some cooldown time in Open, a small trickle of "probe" requests is let through to test if the downstream service has recovered. High success rate → back to Closed. Still failing → back to Open. |

**Key considerations:**
- **What to do with blocked requests while Open?** Usually just **drop them** (with logging, for later analysis) — fine for things like a non-critical profile-image fetch. But for something that must eventually happen (e.g., a shipping-service call in an order flow), use a **log-and-replay** approach: log the failed attempt somewhere durable so it can be retried/completed manually or automatically once the downstream service recovers.
- **What response to give the caller while Open?**
  - **Fail silently** — e.g., return an empty response or a placeholder image.
  - **Best effort** — return a stale/cached version if you have one, rather than nothing.
- **One circuit breaker per external dependency** — don't let one struggling dependency (e.g., shipping service) trip a shared breaker that also blocks calls to unrelated healthy dependencies (e.g., inventory or billing services).
- **Async health-check variant of half-open** — instead of letting real user-triggered requests serve as the "probes," send lightweight, payload-free async health-check pings to the downstream service; close the circuit as soon as those succeed reliably. Saves real user requests from being wasted as unwitting test traffic, and pings are cheaper than real requests — but tuning the right ping frequency has its own trade-offs.

### Pattern: Dead Letter Queue (DLQ)

**The Problem:** In event-driven systems, messages can fail to reach their destination for many reasons — a publisher sending to a nonexistent topic, a full/oversized queue, or a consumer that can't parse/process a specific malformed message. Simply ignoring these lost messages risks silently dropping legitimate business events (e.g., a customer's order). But blindly retrying doesn't always help either — and can make things *worse*: a consumer stuck endlessly retrying one broken message can back up the entire queue, delaying every other message behind it.

**The Pattern:** Introduce a special **Dead Letter Queue** — a dedicated queue/topic in the message broker specifically for messages that couldn't be delivered or processed successfully.

**How messages get there (2 ways):**
1. **Programmatic** — the publisher or consumer explicitly re-publishes a problematic message to the DLQ itself once it detects it can't route/process it, removing it from the original queue.
2. **Automatic (broker-configured)** — many message broker technologies support auto-routing messages to a DLQ when delivery fails (e.g., publish to a nonexistent topic) or when a message has clearly been stuck/retried too many times.

**Best practices:**
- **Tag the failed message with failure context** — error code, stack trace/explanation — typically added as a header, so whoever investigates later knows exactly what went wrong and how to fix it.
- **Actively monitor and alert on the DLQ** — messages shouldn't just sit there forgotten; DLQ volume is itself a signal that something in your system needs fixing.
- **Once fixed, reprocess:** replay the corrected messages back into the original queue for normal processing, or — for rare, low-value, or dead-end cases — have a support engineer manually resolve them case by case (e.g., a customer trying to buy a since-discontinued product).

**Benefit:** keeps your real-time processing pipeline healthy (a few problematic messages don't clog the whole queue), preserves message ordering where the broker configuration supports it, and — crucially — **you never lose the message entirely**.

### Quick Recap — Part 5
- **Throttling/Rate Limiting**: cap request/bandwidth rate (server-side to protect yourself, client-side to protect your budget); respond via reject / queue / degrade, scoped per-API or per-client.
- **Retry**: for short, transient, recoverable failures — always pair with backoff (fixed/incremental/exponential) + jitter + a retry ceiling, and only retry idempotent operations.
- **Circuit Breaker**: for severe, durable failures — stop calling a failing dependency entirely (Closed → Open → Half-open) rather than wastefully retrying; one breaker per dependency.
- **Dead Letter Queue**: catch-all for undeliverable/unprocessable messages — tag with failure context, monitor aggressively, and reprocess once fixed, instead of losing messages or jamming the main queue.

---

## Part 6 — Deployment and Production Testing Patterns

### Pattern: Rolling Deployment

**The Problem:** Upgrading production servers to a new version traditionally needs a maintenance window — but if you get constant traffic, or need an urgent fix during peak hours, taking the whole service offline isn't an option.

**The Pattern:** Instead of taking everything down at once, upgrade servers **one at a time** (or in small batches): use the load balancer to stop sending traffic to a given server → deploy the new version there → optionally run tests → add it back to the rotation → repeat for the next server, until all servers run the new version. If problems appear mid-rollout, reverse the same steps to roll back.

**Pros:** zero downtime, no extra hardware needed (cheap and fast), and you can roll back quickly and transparently if issues appear early.

**Cons:**
- **Cascading failure risk** — if the new version starts erroring on a subset of servers, the load balancer redirects their share of traffic onto the remaining old-version servers, potentially overloading *them* too, and the problem can snowball until no healthy servers remain.
- **Two software versions run simultaneously** for the whole rollout duration — fine if fully backward compatible, risky if the new version has significant API/behavior changes.

Despite these downsides, its simplicity makes Rolling Deployment one of the most widely used deployment patterns in the industry.

### Pattern: Blue-Green Deployment

**The Problem:** Solve Rolling Deployment's two weaknesses (cascading failure risk, and mixed-version traffic) at the cost of extra infrastructure.

**The Pattern:** Keep the current version running fully, unchanged, on its full set of servers — the **Blue environment**. Stand up a completely **separate, equally-sized set of servers** running the new version — the **Green environment**. After verifying Green is healthy (startup checks, smoke tests), use the load balancer to **cut over traffic** from Blue to Green — either all at once or gradually. If problems appear, instantly shift traffic back to Blue. Once confident, either shut down Blue or keep it on standby for the next release cycle.

**Pros:**
- No cascading-failure risk during cutover — Blue is a fully capable, ready-to-go fallback with 100% of the traffic capacity, not a partially-degraded pool.
- Only ever **one version** serving live traffic at any given moment (aside from a brief, generally unnoticeable cutover window) — much simpler than Rolling's "two versions running at once" problem.

**Cons:** you need **double the server capacity** during the deployment window (both Blue and Green fully provisioned) — extra infrastructure cost, and you have to wait for the new environment to fully spin up before cutting over. If this only happens briefly during releases, the added cost is often manageable — which is why this remains one of the most popular deployment choices.

### Pattern: Canary Release & A/B Testing

**The Big Idea:** These are the *same underlying mechanism* used for two *different purposes* — Canary borrows ideas from both Rolling (upgrade in place) and Blue-Green (isolated environment) to get the best of both; A/B Testing reuses that same mechanism but for product experimentation rather than safe rollout.

**Canary Release:**
- Take a **small subset** of your existing server pool and update just those to the new version immediately (no separate environment needed).
- Optionally restrict initial traffic to the canary servers to internal users/beta testers only (via load-balancer request-origin inspection), who tend to tolerate issues better and report them more precisely.
- Monitor the canary's real-time performance vs. the rest of the fleet for **hours or even days** before deciding to proceed.
- If healthy, roll the new version out to the rest of the fleet (commonly via Rolling Deployment).
- Considered the **safest, lowest-risk** deployment pattern of all covered here, precisely because of that long observation window before wide release.
- ⚠️ Key challenge: define clear, **automatable success criteria** upfront — otherwise an engineer is stuck manually eyeballing dozens of dashboards for hours to decide "ship it or roll back."

**A/B Testing:**
- Mechanically identical setup (a small subset of servers/users on an experimental version) — but the **goal is different**: not a *safe rollout* of a version you already intend to ship everywhere, but a genuine **experiment** to measure real-user impact of a change (e.g., a new recommendation algorithm) on a business metric (e.g., revenue).
- Users in the experiment shouldn't know they're in it, so you get authentic, unbiased behavioral data — in practice, most people experience A/B tests constantly online without ever realizing it.
- Experiment duration is up to the team/use case.
- At the end, the experimental version is typically **removed** (unlike Canary, where a successful canary usually *becomes* the new full release) — the collected metrics inform a separate decision by engineers/analysts/data scientists about whether to build the feature "for real" and roll it out properly, or go back to the drawing board.

**Canary vs. A/B Testing — cheat sheet**

| | Canary Release | A/B Testing |
|---|---|---|
| Goal | Safely validate a release before full rollout | Measure real-user impact of a change |
| Typical audience | Internal users / beta testers (often) | Real production users (needed for authentic signal) |
| Outcome if "successful" | Roll out to 100% of fleet | Remove the experimental version regardless; use data to inform a future decision |
| Who decides the outcome | Engineering (health/perf criteria) | Product/business/data teams (business metrics) |

### Pattern: Chaos Engineering (Production Testing)

**The Big Idea:** In a distributed, cloud-based system, failure is *inevitable* — hardware dies, networks partition, third-party APIs go down, unexpected traffic patterns emerge. Unit, functional, and integration tests validate *correctness* of individual pieces, but they can't validate how your *whole system* behaves under real, unpredictable production failure conditions — and by the time a real disaster happens, it's too late to discover your system doesn't handle it gracefully.

**The Pattern:** Deliberately and systematically inject **controlled, random failures into your production system**, on purpose, and observe how the real system actually responds — rather than hoping your assumptions about resilience are correct.

**Types of faults commonly injected:**
- **Killing instances/VMs at random** — the original technique, popularized by Netflix's famous **Chaos Monkey** (built in 2011).
- **Injecting artificial latency** between services, or between a service and its database.
- **Restricting/blocking access** to a database instance or region, to test failover to another replica/zone/region.
- **Resource exhaustion** — deliberately filling up disk space on an instance or database to see how the system copes.
- **Disabling traffic to an entire region/zone**, to verify graceful, transparent failover elsewhere.

**Standard steps for a chaos experiment:**
1. **Measure the baseline** (normal, healthy system behavior) before injecting anything.
2. **Form a hypothesis** — formalize the correct/expected behavior you predict the system *should* exhibit under this fault.
3. **Inject the fault** and observe for a predetermined window.
4. **Record findings.**
5. **Restore the system** to its original state.
6. **Fix any issues found**, then — critically — **keep running these experiments continuously**, not just once. Continuous chaos testing is what catches new regressions as the system evolves, and it also keeps the engineering team's monitoring/dashboards/alerting sharp and battle-tested.

**Key considerations:**
- **Automate fault injection** — use tooling (like Chaos Monkey or similar) rather than manual, human-judgment-based fault injection, to remove bias and make it repeatable.
- **Minimize blast radius** — always run experiments within your system's known error budget. This is actually one more reason you should never promise 100% (or near-100%) availability in an SLA — you need room to safely run these deliberate failure experiments without breaching your own promises.

### Quick Recap — Part 6
- **Rolling Deployment**: upgrade one server at a time via the load balancer — no downtime, no extra hardware, but risk of cascading failures and mixed-version traffic mid-rollout.
- **Blue-Green Deployment**: run old (Blue) and new (Green) as two full, separate environments, then cut over traffic — avoids cascading risk and mixed versions, at the cost of double infrastructure during rollout.
- **Canary Release**: update a small subset in place, observe for hours/days with automatable success criteria, then roll out fully — the safest pattern here.
- **A/B Testing**: mechanically like Canary, but for measuring real business impact of a change on real users, not for safely shipping a release — usually torn down afterward regardless of outcome.
- **Chaos Engineering**: deliberately, continuously inject controlled failures into production to discover weaknesses before real disasters do — always with a hypothesis, a monitored blast radius, and follow-through fixes.

---

## 🧠 Master Glossary (quick-reference)

- **Load Balancing pattern** — one request → one worker; scales throughput horizontally.
- **Pipes and Filters** — chain of independent, stateless, single-purpose processing stages.
- **Scatter-Gather** — one request → all workers in parallel, aggregated into one response.
- **Execution Orchestrator** — central service coordinating a multi-step flow across microservices.
- **Choreography** — decentralized, event-driven coordination across microservices via a message broker.
- **Distributed monolith (anti-pattern)** — all the coupling pain of a monolith + all the overhead of microservices, no real benefits.
- **MapReduce** — map + reduce programming model for parallelizing huge batch computations across many machines.
- **Saga** — sequence of local per-service operations + compensating operations on failure, replacing cross-service ACID transactions.
- **Pivot operation** — the "point of no return" step in a Saga.
- **Transactional Outbox** — Outbox table in the same DB transaction as a business update, guaranteeing atomic "update + event publish."
- **Materialized View** — precomputed, cached result of a specific (usually expensive) query.
- **CQRS** — split the whole system into a write-optimized Command path and a read-optimized Query path.
- **Event Sourcing** — store an immutable, append-only log of events instead of mutable current state; replay to reconstruct state.
- **Sidecar** — co-located companion process handling cross-cutting concerns for a main service.
- **Ambassador** — a sidecar specialized in outbound network communication (proxy-like).
- **Anti-Corruption Adapter** — isolating translation layer between an old/legacy system and a new one.
- **Backends for Frontends (BFF)** — one dedicated backend service per frontend type/platform.
- **Throttling / Rate Limiting** — capping request rate or bandwidth to protect a system (or your budget).
- **Retry** — resending a failed request, with backoff + jitter, for short/transient/idempotent failures.
- **Circuit Breaker** — stop calling a severely/durably failing dependency (Closed → Open → Half-open) instead of endlessly retrying.
- **Dead Letter Queue (DLQ)** — dedicated queue for undeliverable/unprocessable messages, tagged with failure context.
- **Rolling Deployment** — upgrade servers one at a time via the load balancer, zero downtime.
- **Blue-Green Deployment** — two full parallel environments, cut traffic over between them.
- **Canary Release** — update a small subset in place, observe extensively, then roll out fully.
- **A/B Testing** — same mechanism as Canary, but to measure real business impact of a change, not to safely ship a release.
- **Chaos Engineering** — deliberately, continuously injecting controlled failures into production to discover weaknesses proactively.

---

*End of Course 2 study guide. Whenever you're ready, we can do the same for Course 3 — Introduction to Cloud Computing on AWS for Beginners — to map these patterns onto the actual AWS services that implement them.*
