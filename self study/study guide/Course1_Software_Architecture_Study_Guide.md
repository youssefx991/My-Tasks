# 📘 Study Guide: Software Architecture & Design of Modern Large-Scale Systems

> A reading-friendly rewrite of the course, reorganized for self-study. Each lecture is broken into: **The Big Idea**, **Core Concepts** (explained, not just summarized), a **Real-World Example**, and a **Quick Recap**. I've added extra explanations, analogies, and a few "why this matters in practice" notes that go beyond the raw transcript, to help the concepts actually stick.

## 🕐 How to use this guide / suggested study schedule

You don't need to watch a single video. Read top to bottom; each Part is a natural stopping point.

| Part | Topic | Est. reading time |
|---|---|---|
| 1 | Introduction to Software Architecture | 15 min |
| 2 | Requirements & Architectural Drivers | 35 min |
| 3 | Quality Attributes (Fault Tolerance, SLA/SLO/SLI) | 30 min |
| 4 | API Design (Intro, RPC, REST) | 40 min |
| 5 | Building Blocks (LB, DNS, Message Brokers, API Gateway, CDN) | 50 min |
| 6 | Data Storage (SQL, NoSQL, DB techniques, CAP) | 50 min |
| 7 | Architecture Patterns (Microservices, Event-Driven) | 30 min |
| **Total** | | **~4.5 hours** |

Tip: study one Part per sitting. At the end of each Part, close the file and try to explain the concepts out loud from memory — that's the fastest way to actually retain this material (much faster than re-reading).

---

## Part 1 — Introduction to Software Architecture

### The Big Idea
Software architecture is the **structure** of a system — and just like a building, structure isn't optional. Every system has one, whether you deliberately designed it or it just happened. The earlier and more intentionally you design it, the cheaper it is to fix later.

### Core Concepts

**Definition used throughout the course:**
> Software architecture is a **high-level description** of a system's structure — its components, and how those components communicate — in order to fulfill the system's **requirements** and **constraints**.

Let's unpack each part of that definition, because every phrase is doing work:

- **"High-level description"** → Architecture is an *abstraction*. It deliberately hides implementation details. This is the single most common misconception among engineers: architecture is NOT "which framework/database/language do we pick." Those are implementation decisions, made *after* the architecture is settled. Architecture is about the shape of the system, not the materials.
- **"Components... black boxes defined by behavior and APIs"** → A component in an architecture diagram is just a box with a name and a job. You don't need to know how it works inside — only what it does and how to talk to it. Interestingly, this is recursive: any one of those boxes might itself have its own internal architecture diagram, one level down.
- **"Fulfill requirements and constraints"** → Architecture exists to serve a purpose: do what the system *must* do (requirements) without breaking what it *must not* do (constraints).

**Where architecture fits in the software lifecycle:**

Software development ≈ 4 phases: **Design → Implementation → Testing → Deployment**.

Architecture is the **output of the Design phase** and the **input to Implementation**. Get it wrong here, and every phase downstream inherits the mistake — which is why this phase deserves the most care, even though it produces no visible "working code."

### Why this matters in practice
Unlike an algorithm, architecture can't be mathematically proven "correct" or "optimal." There's no unit test for "is this a good architecture." That's exactly why the rest of this course exists — to give you methodical processes and proven patterns instead of pure guesswork.

### Quick Recap
- Architecture = high-level structure + components + communication, in service of requirements/constraints.
- It's an abstraction — technology choices come *after*, not as part of, architecture.
- It sits between Design and Implementation in the dev lifecycle.
- There's no "provably correct" architecture — only methodical processes and proven patterns.

---

## Part 2 — System Requirements & Architectural Drivers

This Part covers the very first step of designing any large-scale system: figuring out, precisely, what you're building.

### Lecture: Introduction to System Design & Architectural Drivers

**The Big Idea:** Gathering requirements for a large-scale system is fundamentally harder than gathering requirements for a method or a class, for two reasons: **scope** and **ambiguity**.

**Core Concepts**

- *Scope problem:* When you implement a method, the input/output are usually already known. When you're asked to "design a ride-sharing service," the scope is enormous and it's easy to feel paralyzed — there's no obvious starting point.
- *Ambiguity problem (two sources):*
  1. Requirements often come from **non-technical stakeholders** (a client, a product manager) who describe things at a high level. Translating vague business language into precise technical requirements is *your* job.
  2. Sometimes **the client themselves doesn't know exactly what they need** — only the problem they're trying to solve. Asking the right clarifying questions (real-time or async? mobile or desktop? who handles payment?) *is itself part of the solution*. This is why system-design interviews specifically test your ability to ask good clarifying questions before jumping to a diagram.

- **Why you can't "just iterate" your way through a bad start:** Small code can be rewritten cheaply. A large-scale system involves multiple engineering teams, months of work, hardware/software purchases, and contractual commitments. Restructuring after the fact is enormously expensive — so investing time upfront in requirements is not optional, it's risk management.

**The Three Types of Requirements (a.k.a. Architectural Drivers)**

| Type | Also called | Describes | Affects architecture? |
|---|---|---|---|
| **Features** | Functional requirements | What the system *does* (input → output) | ❌ Generally does not dictate architecture — almost any architecture can implement any feature |
| **Quality attributes** | Non-functional requirements | What properties the system *has* (scalability, availability, security, performance...) | ✅ Yes — these are what actually shape your architecture |
| **System constraints** | — | Limitations/boundaries on the solution space | ✅ Yes — they narrow your options |

This table is one of the most important mental models in the whole course: **features tell you *what* to build, quality attributes and constraints tell you *how* to build it.** Two systems can have identical features (e.g., two ride-sharing apps) and completely different architectures because their quality-attribute priorities differ.

They're called "architectural drivers" because together they *drive* your decisions from an infinite space of possible designs down to one that actually fits your client's needs.

### Lecture: Feature Requirements — Step by Step Process

**The Big Idea:** Don't just ask the client to "describe everything." Use a structured 3-step method.

**Core Concepts — the 3 steps:**
1. **Identify all actors/users** in the system (e.g., in a ride-hailing app: rider, driver).
2. **Enumerate use cases** — the scenarios in which each actor interacts with the system (registration, login, matching a ride, failed match, etc.).
3. **Expand each use case into a flow of events** — a detailed, step-by-step interaction between actor and system, capturing both the *action* and the *data* exchanged.

**Tool: the Sequence Diagram.** This is a standard UML diagram type where:
- Time flows top → bottom.
- Each actor/entity is a vertical line ("swimlane").
- Solid arrows = requests/calls; dashed arrows = responses.

*Example walkthrough (ride-hailing):* driver goes online → rider requests a ride → system matches them → both notified → ride starts → ride completes → system charges rider, pays driver (minus fee) → both parties notified.

**A neat side benefit:** once you've mapped out these interactions, you've essentially already sketched your **future API** — each interaction is a potential API call, and the data flowing in each step becomes the call's parameters.

### Lecture: System Constraints in Software Architecture

**The Big Idea:** A constraint is a decision that's *already been made for you* — it removes some of your freedom, but it also gives you a fixed starting point ("a pillar") to design around.

**Core Concepts — the 3 types of constraints:**

1. **Technical constraints** — e.g., locked into a specific cloud vendor, must use a certain language/database, must support old browsers/devices. These can force you away from architectures you'd otherwise prefer (e.g., no auto-scaling if you're required to run on-premise).
2. **Business constraints** — budget, deadlines, mandated third-party integrations (e.g., "use this payment processor," "use this fraud-detection vendor"). Small startups and large enterprises tend to favor genuinely different architectural patterns because of these constraints.
3. **Legal/regulatory constraints** — e.g., HIPAA (US healthcare data), GDPR (EU data privacy). These vary by industry and geography.

**Two things to always do with constraints:**
- **Don't accept constraints too easily.** Distinguish *real* constraints (a law) from *self-imposed* ones (an old vendor contract that might actually be negotiable). Once you commit to designing around a constraint, walking it back later is painful.
- **Leave room to escape constraints later.** Even if you're locked into a particular database/vendor today, avoid tightly coupling your whole system to it, so that if the constraint disappears in the future, you can adapt with minimal rework (rather than a full re-architecture).

### Quick Recap — Part 2
- Requirements = Features (what) + Quality Attributes (how well) + Constraints (limits). Only the last two shape architecture.
- Use actors → use cases → sequence diagrams to formally capture functional requirements.
- Treat constraints skeptically (are they *really* fixed?) and design with an escape hatch.

---

## Part 3 — The Most Important Quality Attributes in Large-Scale Systems

### Lecture: Fault Tolerance & High Availability

**The Big Idea:** Failures are inevitable at scale. High availability isn't achieved by *preventing* all failures — it's achieved by building a system that stays useful *despite* failures.

**Core Concepts**

**3 sources of failure:**
1. **Human error** — bad config push, wrong command, undertested release.
2. **Software errors** — crashes, memory leaks, long garbage-collection pauses.
3. **Hardware failures** — servers/routers/disks dying, power outages, network issues.

**Fault tolerance = 3 tactics:**

1. **Prevention** — mainly via **eliminating single points of failure** through **replication/redundancy**:
   - *Spatial redundancy*: run multiple instances of your app/database across multiple machines.
   - *Time redundancy*: simply retry an operation until it succeeds or you give up.
   - Two replication strategies:
     - **Active-active**: all replicas take live traffic and stay in sync with each other. ➜ Pro: load spreads across replicas (scales horizontally). Con: keeping everyone in sync requires coordination overhead.
     - **Active-passive**: one primary takes all requests; others just shadow it via periodic snapshots. ➜ Pro: simple, clear leader. Con: no scalability benefit (all traffic still hits one machine).

2. **Detection & isolation** — you need a separate **monitoring service** that either:
   - Actively pings instances (health checks), or
   - Passively listens for periodic "heartbeat" signals.
   - If a server misses too many checks/heartbeats, it's presumed dead and removed from rotation. A false positive (flagging a healthy server as dead) is tolerable; a **false negative** (missing a real failure) is not.
   - More advanced monitoring also tracks error rates and response-time trends per host, not just "is it up."

3. **Recovery** — once a bad instance is isolated:
   - Stop routing traffic to it.
   - Try a **restart**.
   - **Rollback** to a previously known-good version/state (very common for both software deploys and database states).

**Why this matters in practice:** There's a formula-level insight buried here — *if your system recovers from failures faster than the user can notice, your effective availability looks perfect, regardless of your raw failure rate.* Speed of detection+recovery matters as much as preventing failures in the first place.

### Lecture: SLA, SLO, SLI

**The Big Idea:** These three terms describe how you formally promise, target, and measure quality attributes.

| Term | What it is | Who defines it |
|---|---|---|
| **SLA** (Service Level Agreement) | A **legal contract** with customers, bundling the important promises (availability, performance, data durability, etc.) and the **penalties** if you fail to meet them (refunds, credits, extensions) | Business/legal team |
| **SLO** (Service Level Objective) | An individual **target value** for one metric (e.g., "99.9% availability," "<100ms response time at p90") | Engineers/architects |
| **SLI** (Service Level Indicator) | The **actual measured number**, from monitoring/logs, that you compare against the SLO | Engineers/architects |

Think of it as a nesting doll: **SLA** is the legal wrapper containing multiple **SLOs**, and **SLIs** are the real-world numbers you check against those SLOs.

**4 considerations when defining SLOs:**
1. Start from what users actually care about, then pick indicators (SLIs) for those — don't set an objective for every metric you're *able* to measure.
2. Fewer SLOs = better. Too many makes it impossible to prioritize.
3. Leave a margin of error — don't promise the absolute max you could theoretically hit (e.g., promise 99.9% externally even if you can hit 99.99% internally — cheaper, safer, and leaves buffer for surprises).
4. Have a **recovery plan** ready in advance for when SLIs show you're breaching an SLO (alerts, auto-failover, rollback policies, runbooks) — so the on-call engineer isn't improvising during an incident.

### Quick Recap — Part 3
- High availability = fault tolerance = prevention (redundancy) + detection (monitoring) + recovery (restart/rollback).
- Active-active = more scalable but harder to keep in sync; active-passive = simpler but doesn't scale.
- SLA (legal promise) ⊃ SLOs (targets) ⊃ measured via SLIs (real numbers).

---

## Part 4 — API Design

### Lecture: Introduction to API Design for Software Architects

**The Big Idea:** Once you know your system's behavior (features), you need to define the **contract** — the API — that other applications use to talk to it.

**Core Concepts**

**3 categories of APIs:**
- **Public** — open to any developer; typically requires registration for security/control.
- **Private/internal** — used only within your own company/org.
- **Partner** — like public, but restricted to companies/users with an actual business relationship (a signed agreement).

**Best practices for good API design:**
- **Complete encapsulation** — the client should never need to know internal implementation details. If they do, the abstraction has failed.
- **Ease of use** — one obvious way to do each task, descriptive names, expose only what's needed, be consistent.
- **Idempotency** — an idempotent operation produces the same end result no matter how many times it's called (e.g., "set address to X" is idempotent; "increment balance by $100" is not). This matters hugely over unreliable networks — if a client isn't sure whether a request succeeded, it can safely just retry an idempotent call.
- **Pagination** — never return an unbounded dataset in one response (imagine your inbox loading *every* email you've ever received on one page). Let the client request small pages via a limit + offset.
- **Asynchronous operations** — for long-running tasks (report generation, video compression), don't make the client wait. Return an immediate acknowledgment + a tracking ID, and let them poll or get notified later.
- **Explicit versioning** — lets you evolve the API (even with breaking changes) while giving existing clients time to migrate, instead of breaking them overnight.

### Lecture: RPC (Remote Procedure Call)

**The Big Idea:** RPC makes a network call *look and feel* like calling a normal local method. This property is called **local transparency**.

**Core Concepts**

**How it works:**
1. You define the API + data types using an **Interface Description Language (IDL)** — a schema for the client-server contract.
2. A code generator produces two auto-generated pieces: a **client stub** and a **server stub**.
3. At runtime: client calls the method → client stub **serializes** ("marshals") the data → sends it over the network → server stub **deserializes** it and invokes the real method → result flows back through the same stubs.

**Data Transfer Objects (DTOs)** are the auto-generated classes/structs representing your custom types from the IDL.

**Benefits:**
- Very convenient for developers — feels like local method calls.
- Network failures surface simply as exceptions/errors, same as any local call.

**Drawbacks (and why they matter):**
- **Slower & less reliable than local calls** — but the code *looks* deceptively fast, so it can hide performance bottlenecks. Mitigate with async versions of slow methods.
- **Ambiguous failure semantics** — if a call to "debit account" fails, did the server never receive it, or did it process it and the *response* got lost? The client can't tell. This is the classic "should I retry and risk double-charging, or not retry and risk not charging at all" dilemma. Mitigate by making operations **idempotent**.

**When to use RPC:** great for **backend-to-backend** communication (especially between internal system components, or system-to-system integrations with other companies), less common for browser/frontend clients. Best when you want to fully abstract away the network and think purely in terms of "actions," and when your API is more action-oriented (lots of distinct method names) rather than data/resource-oriented.

### Lecture: REST API

**The Big Idea:** REST takes the *opposite* philosophy from RPC — instead of exposing many custom methods, it exposes a small, fixed set of operations on **named resources**.

**Core Concepts**

- **Resource-oriented, not method-oriented.** The main abstraction is a *resource* (e.g., "a user," "a movie"), not an action.
- **A tiny, fixed vocabulary of operations**, mapped to HTTP methods:

| Operation | HTTP Method |
|---|---|
| Create | POST |
| Read (get state) | GET |
| Update | PUT |
| Delete | DELETE |

- **HTTP semantics you get "for free":**
  - `GET` is **safe** (never changes state) and typically **cacheable** by default.
  - `GET`, `PUT`, `DELETE` are **idempotent** by convention.
  - `POST` responses *can* be made cacheable via headers.

- **Statelessness is required.** The server shouldn't remember anything about a client between requests. This is what lets you freely spread traffic across many server instances (any instance can handle any request), directly enabling high scalability and availability.

- **Resource hierarchy:** resources are either **simple** (a single entity, singular name, e.g. `/movies/123`) or **collections** (a list of same-type resources, plural name, e.g. `/movies`), nested via `/`. E.g. `/movies/123/reviews` = the reviews sub-collection of movie 123.

- **HATEOAS** (Hypermedia As The Engine Of Application State): responses can include *links* to related actions/resources, so the API's possible next steps are discoverable dynamically rather than hard-coded ahead of time by the client.

- **Naming best practices:**
  - Use **nouns**, not verbs (verbs are implied by the HTTP method).
  - Plural for collections, singular for individual resources.
  - Meaningful, specific names — avoid generic names like "items" or "objects."
  - URL-friendly, unique identifiers.

**Step-by-step process to design a REST API** (worked example: a movie streaming service):
1. Identify entities (users, movies, reviews, actors).
2. Map entities → URIs, organized by hierarchy/relationship (e.g., reviews nest under movies because each review belongs to one movie).
3. Choose a representation for each resource (usually JSON).
4. Assign HTTP methods (POST/GET/PUT/DELETE) to the actions available on each resource.

### RPC vs REST — mental cheat sheet
| | RPC | REST |
|---|---|---|
| Mental model | Actions/methods | Resources/nouns |
| Best for | Backend-to-backend, internal services, other companies' systems | Public/web-facing APIs, resource-centric CRUD systems |
| Flexibility of operations | Unlimited custom methods | Small fixed set (GET/POST/PUT/DELETE) |
| Coupling to network details | Fully abstracted away | Client can leverage HTTP directly (headers, caching, cookies) |

### Quick Recap — Part 4
- APIs = public / private / partner. Good APIs: encapsulated, easy to use, idempotent, paginated, async where needed, versioned.
- RPC = feels like local method calls; great backend-to-backend; watch out for hidden latency and ambiguous failure semantics.
- REST = resource-oriented, small fixed verb set mapped to HTTP methods, stateless (→ scalability), cacheable.

---

## Part 5 — Large-Scale Systems Architectural Building Blocks

### Lecture: DNS, Load Balancing & GSLB

**The Big Idea:** A load balancer spreads traffic across a group of servers so no single server is overwhelmed — and as a side effect, it hides your internal server topology from clients.

**Core Concepts**

**Quality attributes a load balancer gives you:**
- **Scalability** — add/remove server instances behind it transparently; combine with cloud auto-scaling policies.
- **High availability** — it monitors server health and stops routing to dead/unresponsive servers.
- **Performance** — adds a small amount of latency, but massively increases overall throughput because load is spread.
- **Maintainability** — you can take servers down one at a time for maintenance/upgrades without any client-visible disruption (rolling releases).

**4 types of load balancing solutions, from simplest to smartest:**

1. **DNS load balancing** — DNS returns a *rotating list* of IPs for a domain (round-robin). ➕ Free, simple. ➖ No health checks (keeps routing to dead servers), dumb round-robin only (can't account for server load/power differences), exposes real server IPs (security risk — a malicious client can target one server directly).

2. **Hardware load balancers** — dedicated physical devices built for this job.

3. **Software load balancers** — the same functionality, but as software running on general-purpose machines. Both hardware and software LBs: hide real server IPs, actively health-check, and balance intelligently (accounting for load, connections, hardware differences). Also usable *internally* between your own services, not just at the "front door."
   - ⚠️ Limitation: LBs are usually **co-located** with the servers they balance (to avoid extra latency) — so a single LB doesn't help you if you have data centers in multiple geographic regions.

4. **GSLB (Global Server Load Balancer)** — a hybrid of DNS + smart load balancer:
   - Acts as a DNS service but makes **intelligent routing decisions** using the client's geographic origin, real-time server/data-center health, and load.
   - Typically returns the address of the *nearest healthy* regional load balancer.
   - Crucial for **disaster recovery** — if a whole data center goes down, GSLB reroutes users elsewhere automatically.

### Lecture: Message Brokers

**The Big Idea:** Message brokers enable **asynchronous** communication — the sender doesn't have to wait for (or even know about) the receiver.

**Core Concepts**

**The problem with synchronous communication:**
- Both sender and receiver must be alive and connected at the same time.
- Long-running operations force the caller to sit and wait (bad UX, ties up resources, and if the server crashes mid-operation you have to start over).
- No "shock absorber" for traffic spikes — e.g. a flash sale can flood a slow "fulfil order" service even if the fast "front-end" service scales fine.

**What a message broker is:** a building block that stores messages in a **queue** between senders (producers) and receivers (consumers), fully decoupling them. Unlike a load balancer (used for *external*-facing traffic), a message broker is typically an internal building block.

**Key benefits:**
- **Decoupling** — sender doesn't wait for a response; receiver doesn't even need to be online at send time.
- **Buffering** — absorbs traffic spikes; e.g. during a flash sale, orders pile up in the queue and get processed steadily afterward instead of crashing the fulfillment service.
- **Publish/Subscribe (pub/sub) pattern** — multiple services can subscribe to the same event channel. You can bolt on new features (analytics, push notifications, fraud checks) just by adding new *subscribers*, with **zero changes** to existing services.

**Quality attributes gained:** higher **availability** (fault tolerance to temporary outages, no lost messages) and higher **scalability** (buffering absorbs spikes). Trade-off: a bit more **latency** due to the added indirection, though usually negligible.

### Lecture: API Gateway

**The Big Idea:** Once you split a monolith into multiple services, clients suddenly need to know about — and call — many different services. An API Gateway restores a single, simple front door.

**Core Concepts**

The API Gateway sits between clients and your backend services, and implements **API composition**: it exposes one unified API, and internally fans requests out to (and aggregates responses from) the right backend services.

**Benefits:**
- **Internal changes stay invisible to clients** — you can split/merge/replace services behind the scenes freely.
- **Centralized security** — authentication, authorization, and SSL termination happen in one place instead of being duplicated (and re-implemented, and re-tested) in every service. Also a natural place for **rate limiting** to block abuse/DoS attempts.
- **Better performance** — via **request routing** (client makes 1 call, gateway fans it out to N services and aggregates the response — saving multiple round trips) and **caching** at the gateway layer.
- **Monitoring/alerting** — since all traffic flows through one point, you get centralized visibility.
- **Protocol translation** — e.g., expose REST/JSON externally while internal services use different RPC protocols or legacy formats; also useful for supporting external partners who need a different protocol than your internal standard.

**Best practices / anti-patterns to avoid:**
- ❌ Don't put **business logic** in the API Gateway — its job is composition and routing, not decision-making. Otherwise you just recreate a monolith, one layer up.
- ⚠️ Because *all* traffic goes through it, the Gateway can become a **single point of failure** — mitigate with multiple instances behind a load balancer, and be extra cautious about how you deploy changes to it.
- ❌ Don't let clients **bypass the Gateway** to call services directly "for optimization" — that reintroduces the tight coupling problem the Gateway was built to solve.

### Lecture: Content Delivery Network (CDN)

**The Big Idea:** No matter how well-architected your backend is, physical distance and network hops add latency that you simply cannot engineer away at the origin server — so you cache content *physically closer* to users instead.

**Core Concepts**

**The latency problem, illustrated:** a user in Brazil loading a US-hosted page might pay ~3 seconds total from TCP handshake + page load + asset loading — and studies have shown a majority of mobile users abandon a page that takes longer than 3 seconds.

**What a CDN does:** it's a globally distributed network of **edge servers** at strategic "points of presence" that cache your static content (images, JS, CSS, HTML, video) physically near your users, dramatically cutting load time. It also improves **security** (absorbing DDoS traffic across its huge server network) and **availability** (users are served from the CDN cache even if your origin has issues).

**Two publishing strategies:**

| Strategy | How it works | Pros | Cons |
|---|---|---|---|
| **Pull** | You configure which assets to cache + a TTL (time-to-live). CDN fetches on first request, then caches until expiry. | Low maintenance — CDN handles it automatically | First user per asset pays the "cold" latency; identical TTLs across assets can cause synchronized cache-expiry traffic spikes back to your origin; your origin still needs decent uptime |
| **Push** | You (manually or automatically) upload/publish content to the CDN whenever it changes. | Once pushed, traffic goes straight to edge servers — origin barely matters, even during your own outages | You're responsible for re-publishing on every change; stale content risk if you forget |

### Quick Recap — Part 5
- **Load balancing**: DNS (cheap, dumb) → hardware/software (smart, hides IPs, health checks) → GSLB (geo-aware, disaster recovery).
- **Message brokers**: decouple services, buffer traffic spikes, enable pub/sub for painless feature additions.
- **API Gateway**: single front door — composition, security, performance, monitoring, protocol translation — but keep it logic-free and don't let it become a hidden monolith or SPOF.
- **CDN**: cache content near users to defeat physical-distance latency; choose Pull (low maintenance) vs Push (fresher, less origin dependency) based on how often content changes.

---

## Part 6 — Data Storage at Global Scale

### Lecture: Relational Databases & ACID Transactions

**The Big Idea:** Relational (SQL) databases organize data into related tables, and guarantee very strong correctness properties (ACID) at the cost of rigidity.

**Core Concepts**

- Data is stored in **tables**; each row = a record; each column has a name/type/constraints. Records relate to each other across tables (hence "relational").
- Each record has a unique **primary key**; the table's structure (**schema**) is fixed ahead of time.
- Query language: **SQL**.
- **Space efficiency via normalization**: instead of duplicating a product's full details into every order row, you store just a **foreign key** (product ID) in the orders table and `JOIN` back to the products table when needed. This avoids duplication and saves storage.

**ACID, explained with the classic money-transfer example:**

| Property | Guarantee | Money-transfer analogy |
|---|---|---|
| **Atomicity** | A transaction happens *entirely* or *not at all* | Money is never withdrawn from A without appearing in B, even momentarily |
| **Consistency** | Once committed, a transaction is visible to all future reads, and never violates data constraints | No future query ever "un-sees" a completed transfer; a $1000 balance cap is never violated |
| **Isolation** | Concurrent transactions don't see each other's in-progress (intermediate) state | A second concurrent transfer never sees money "in both accounts at once" |
| **Durability** | Once committed, the result is permanent | A completed purchase record can't just vanish afterward |

**Advantages:** powerful/flexible queries (deep business insight), efficient storage via joins, human-friendly table structure, strong ACID guarantees.

**Disadvantages:** rigid schema (changing it requires migrations/downtime-ish maintenance), harder/costlier to scale, generally slower reads than NoSQL alternatives.

**When to use:** when you need complex/flexible querying, or you need strict ACID transactional guarantees between entities.

### Lecture: Non-Relational Databases (NoSQL)

**The Big Idea:** NoSQL databases trade some of SQL's structure and guarantees for flexibility and raw query speed.

**Core Concepts**

**Why NoSQL exists:** relational databases force uniform schemas across a whole table (bad fit for irregular data), only really support one data structure (the table, which isn't how most programming languages naturally model data), and were originally optimized for storage efficiency rather than query speed.

**3 main categories:**

1. **Key/Value store** — essentially a giant hash table; the value is opaque (int, string, blob, whatever). Great for counters, caching, simple lookups.
2. **Document store** — stores semi-structured "documents" (JSON/YAML/XML-like objects with varying attributes), which map naturally onto objects/classes in code.
3. **Graph database** — an extension of document stores, optimized for traversing/analyzing *relationships* between records. Classic use cases: fraud detection (spotting the same real person behind multiple accounts) and recommendation engines (people who bought X also bought Y, or "friends of friends" suggestions).

**Trade-offs vs relational:** you generally lose easy analytics/joins across records and lose ACID guarantees (with some exceptions) — in exchange for flexible schemas and faster queries.

**When to use NoSQL:**
- Caching layers (in-memory key/value stores are ideal).
- Real-time big data, where SQL is too slow/doesn't scale.
- Unstructured or highly variable data (user profiles, content management with mixed media types).

### Lecture: Techniques to Improve Performance, Availability & Scalability of Databases

**The Big Idea:** Three techniques — orthogonal to each other, usually combined in real systems — improve different database qualities.

**Core Concepts**

| Technique | Improves | How it works | Trade-off |
|---|---|---|---|
| **Indexing** | Query **performance** | A helper structure (hash table or B-tree) mapping column value(s) → row, avoiding full-table scans. Composite indexes (multiple columns) speed up multi-condition queries. | More storage; **slower writes** (index must be updated on every insert/update) |
| **Replication** | **Availability** + read **throughput** | Run multiple copies of the DB on different machines; if one dies, others serve. | Higher complexity, especially for writes/updates (keeping replicas in sync) |
| **Partitioning / Sharding** | **Scalability** (storage volume + parallel query throughput) | Split data across multiple DB instances (rather than duplicating it) — different queries hit different shards in parallel | Complexity of routing queries to the right shard, keeping shard sizes balanced |

Note: NoSQL databases usually support replication and sharding "out of the box" because they're designed with decoupled records in mind. Relational databases support these to varying degrees depending on implementation, because joins/ACID guarantees are much harder to maintain across a distributed, sharded relational store.

### Lecture: Brewer's (CAP) Theorem

**The Big Idea:** In a **distributed** database, when a network partition occurs, you must choose between **Consistency** and **Availability** — you cannot have both at that moment.

**Core Concepts**

- **C — Consistency** (CAP definition, note: *not* the same "C" as ACID's consistency!): every read gets either the **most recent write**, or an error. All clients see the same value at the same time.
- **A — Availability**: every request gets a **non-error response**, but it's not guaranteed to be the latest value (might be stale).
- **P — Partition tolerance**: the system keeps working even when network messages between nodes are lost or delayed.

**The key insight:** network partitions are inevitable eventually for *any* distributed system — so realistically, you must accept partition tolerance (P) as a given, which forces you to actually choose between **C and A** whenever a partition happens. (The only way to get both C and A always is to run on a *single* machine — but that doesn't scale or tolerate failure at all.)

**When there's no partition** (the normal, common case), you don't have to sacrifice anything — the trade-off only bites *during* a partition event.

**How to decide which to favor:**
- Favor **Consistency** when correctness is critical and stale data is dangerous — e.g., inventory count for the last item in stock (you don't want two customers both "successfully" buying the last unit).
- Favor **Availability** when a slightly-stale response is harmless — e.g., a "likes" or "view count" on a social media post; an error screen would be a worse experience than a slightly outdated number.

**Not actually binary in practice:** most real distributed databases let you *tune* how much consistency vs. availability you want, like a dial rather than an on/off switch.

### Quick Recap — Part 6
- SQL: flexible/powerful queries, ACID guarantees, rigid schema, harder to scale.
- NoSQL: flexible schema, fast queries, weaker/no ACID, harder to do cross-record analytics. 3 flavors: key/value, document, graph.
- Indexing (speed) / Replication (availability + read throughput) / Sharding (scalability) are independent, commonly combined techniques.
- CAP theorem: during a network partition, pick Consistency **or** Availability, not both. No partition = no trade-off needed.

---

## Part 7 — Software Architecture Patterns and Styles

### Lecture: Microservices Architecture

**The Big Idea:** As a monolithic codebase and team grow, development slows down and becomes error-prone. Microservices break the system into small, independently deployable, team-owned services to restore speed.

**Core Concepts**

**Why move away from monolith:** a single large "three-tier" monolithic application becomes hard to build/test/load in an IDE as it grows, and more engineers on one codebase means more merge conflicts and slower coordination (the "organizational scalability" problem, not just a technical one).

**What microservices give you:**
- **Smaller codebases per service** → faster builds/tests, easier onboarding, easier troubleshooting.
- **Lighter-weight instances** → each service uses less CPU/memory, runs fine on cheaper commodity hardware, scales horizontally.
- **Organizational autonomy** → each small team can pick its own language/framework/release cadence, and teams can ship independently and in parallel.
- **Fault isolation** → a crash in one service is easier to contain than a crash in a giant monolith (better resilience/security posture).

**⚠️ Two things people underestimate:**
1. You don't get these benefits automatically just by chopping a monolith into arbitrary pieces — poor service boundaries lead to a **"Big Ball of Mud"** (a distributed monolith with all the coordination pain of microservices *and* all the coupling problems of a monolith).
2. Microservices come with real overhead (network calls between services, distributed data, operational complexity) — this style only pays off once you've actually hit the scale/complexity where a monolith is holding you back. **Start monolithic, migrate when it hurts** — don't jump to microservices prematurely.

**Best practices for real decoupling:**
- **Single Responsibility Principle per service** — each microservice owns exactly one business capability/domain/resource (e.g., in a dating app: user-profile service, image service, matching service, billing service — each independently changeable).
- **Separate database per service** — if two services share a database, every schema change needs cross-team coordination, defeating the whole point. Each service's database becomes a private implementation detail it can change freely. (Some data duplication across services is an accepted cost of this approach.)

### Lecture: Event-Driven Architecture

**The Big Idea:** Instead of services calling each other directly (and being coupled to knowing each other's existence/API), services only produce and consume **events** through a shared **message broker**.

**Core Concepts**

**3 components:**
- **Event emitters / producers**
- **Event channel** (the message broker — same building block from Part 5)
- **Event consumers**

An **event** = an immutable statement of fact or change (e.g., "item added to cart," "device moved position").

**Why this beats direct service-to-service calls:**
- **Zero coupling** — producer doesn't need to know what (or how many) consumers exist, or wait for a response.
- **Effortless extensibility** — want to add fraud detection, push notifications, or a third-party billing integration? Just add a new subscriber to the existing event stream — **zero changes** to existing producers/consumers.
- **Real-time stream analysis** — services can react to patterns *as they happen* (e.g., a fraud-detection service spotting two purchases in different cities within an hour, or 5 transactions in a suspiciously short time window, and freezing the account immediately) — no need to wait for batch processing.

**Two powerful patterns unlocked by event-driven architecture:**

1. **Event Sourcing** — instead of storing *current state* in a database, you store the full **immutable log of events**, and derive the current state by replaying them. Benefits: full audit history "for free," and corrections (e.g., a fraudulent charge) can be fixed by appending a *compensating event* rather than mutating history. You can optimize replay time with periodic **snapshot events**.

2. **CQRS (Command Query Responsibility Segregation)** — separates the **write path** from the **read path** into different services/databases, each optimized for its own workload:
   - Solves the "read-heavy and write-heavy at the same time" contention problem, by letting update operations go to a write-optimized service/DB and publish events, while a separate read-optimized service/DB subscribes to those events and serves all queries.
   - Also solves **cross-service joins**: instead of joining data live across multiple microservice databases (slow, and painful once data types differ), a dedicated service subscribes to change events from multiple sources and maintains a pre-joined, ready-to-query **materialized view** in its own read-only store. (Example: a product-search service that pre-joins product info + reviews so search queries never have to call two separate services live.)

### Quick Recap — Part 7
- Microservices: small, independently owned/deployed services, one business capability + one database each — huge dev-speed and scalability wins, but only worth the overhead once a monolith is genuinely holding you back.
- Event-driven architecture: fully decouples services via a message broker; enables real-time reaction to data streams and painless extensibility.
- Event Sourcing = store events, not state, and replay to reconstruct state.
- CQRS = split reads and writes into separate optimized paths; also solves cross-service "joins" via materialized views.

---

## 🧠 Master Glossary (quick-reference)

- **Architecture** — high-level structure: components + how they communicate, to satisfy requirements/constraints.
- **Functional requirement** — what the system does; doesn't dictate architecture.
- **Quality attribute (non-functional requirement)** — a property the system has (scalability, availability, etc.); *does* dictate architecture.
- **Constraint** — a pre-made decision limiting your design freedom.
- **Fault tolerance** — staying operational despite component failures.
- **SLA / SLO / SLI** — legal promise / individual target / measured value.
- **Idempotent** — repeating an operation has the same effect as doing it once.
- **RPC** — remote method calls that look local; action/method-oriented.
- **REST** — resource-oriented API style using a fixed HTTP verb set; stateless.
- **Load balancer** — distributes traffic across servers; also hides internal topology.
- **GSLB** — geography-aware, health-aware DNS-style load balancer across data centers.
- **Message broker** — queue-based building block enabling async, decoupled communication.
- **API Gateway** — single entry point composing multiple backend APIs into one client-facing API.
- **CDN** — distributed edge-server network caching content near users.
- **ACID** — Atomicity, Consistency, Isolation, Durability (SQL transaction guarantees).
- **CAP theorem** — during a network partition, pick Consistency or Availability, not both.
- **Sharding/Partitioning** — splitting data across multiple DB instances for scalability.
- **Microservices** — small, independently deployable, single-responsibility services.
- **Event-driven architecture** — services communicate via immutable events through a broker.
- **Event Sourcing** — store an append-only event log; derive state by replay.
- **CQRS** — separate read and write paths/databases for performance and cross-service joins.

---

*End of Course 1 study guide. Next up whenever you're ready: Course 2 — The Complete Cloud Computing Software Architecture Patterns (the pattern catalog that builds on this foundation).*
