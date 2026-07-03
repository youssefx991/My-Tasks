# 📙 Study Guide: Introduction to Cloud Computing on AWS for Beginners

> A reading-friendly rewrite of Course 3 — much more hands-on/service-by-service than Courses 1 and 2. This guide focuses on the **conceptual core** of each lecture (the "why" and "how it fits together"), and briefly notes what each hands-on lab (HOL) has you actually practice in the console, so you understand the skill even without doing the click-through yourself. Extra comparison tables and explanations are added throughout — especially useful since this course is also a great primer for the AWS Certified Cloud Practitioner / Solutions Architect Associate exams.

## 🕐 Suggested study schedule

| Part | Topic | Est. reading time |
|---|---|---|
| 1 | Let's Get Started (intro, account, tools) | 15 min |
| 2 | AWS Fundamentals | 30 min |
| 3 | Authentication & Access Control (IAM) | 25 min |
| 4 | EC2, Auto Scaling & Load Balancing | 45 min |
| 5 | Virtual Private Cloud (VPC) | 45 min |
| 6 | Storage Services | 35 min |
| 7 | Database Services | 30 min |
| 8 | Automation & DevOps | 30 min |
| 9 | DNS, Caching & Performance | 30 min |
| 10 | Containers & Serverless Computing | 40 min |
| 11 | Machine Learning & AI | 15 min |
| 12 | Certification | 10 min |
| **Total** | | **~5.5 hours** |

---

## Part 1 — Let's Get Started

### Core Concepts

**Getting an AWS account:** you need a credit card + a unique email address (you can reuse the same card across multiple accounts using "plus addressing" email aliases, e.g. `you+aws1@gmail.com`). Creating an account creates the **root user**, tied to that email. The root user has full, largely un-restrictable permissions — which is exactly why you should almost never use it day-to-day. Best practice: set a strong password + MFA on root, then immediately create an individual **IAM user** for yourself and use that instead.

**3 ways to manage AWS**, all ultimately hitting the same underlying API:
1. **Management Console** — the web-based GUI.
2. **CLI (Command Line Interface)** — installable locally, or run in the browser via **AWS CloudShell** (pre-authenticated as whoever you're logged in as — genuinely convenient for quick commands without local setup).
3. **SDKs** — for developers writing application code (e.g., `boto3` for Python) that talks directly to the AWS API.

### Quick Recap — Part 1
- Root user = all-powerful, avoid daily use; create an IAM user instead.
- Console / CLI / CloudShell / SDK are just different front doors to the same underlying API.

---

## Part 2 — AWS Fundamentals

### Core Concepts

**AWS Global Infrastructure — the building blocks:**

| Component | What it is |
|---|---|
| **Region** | A separate physical location in the world (growing in number over time) |
| **Availability Zone (AZ)** | One or more physically separate data centers within a region (usually 3+ per region); spreading resources across AZs protects you from a single data center failure |
| **AWS Global Network** | AWS's own private backbone connecting regions — high bandwidth, managed latency |
| **Outposts** | AWS hardware installed in *your* data center, running a subset of AWS services on-premises, connected back to a region |
| **Local Zones** | AZ-like infrastructure closer to metropolitan areas, for lower latency to nearby users |
| **Wavelength Zones** | Infrastructure embedded in 5G telecom networks, for ultra-low-latency mobile applications |

Within an AZ, you carve out **subnets** (public or private) — that's where you actually launch resources. **CloudFront** (AWS's CDN) caches content at edge locations worldwide, reducing latency for globally distributed users — this is also considered part of the Global Infrastructure story.

**The AWS Shared Responsibility Model** — the single most tested concept on AWS exams:

| AWS is responsible for... | You are responsible for... |
|---|---|
| "Security **of** the cloud" | "Security **in** the cloud" |
| Physical data centers, hardware, global network, the managed services' underlying infrastructure | Your data, IAM configuration (users/roles/policies/permissions), OS patching (for unmanaged compute like EC2), network/firewall configuration (security groups, NACLs), encryption of your data at rest/in transit |

The dividing line shifts depending on the service — e.g., for a fully managed database AWS patches more for you than for a raw EC2 instance — but data and access-control decisions are *always* yours.

**APIs — the universal language of AWS:** every single action you take on AWS — whether through the Console, CLI, or an SDK — ultimately becomes an **HTTP(S) API call**. Console clicks are just a friendly wrapper around API requests. AWS APIs map naturally onto HTTP methods: `GET` retrieves (e.g., S3's `GetObject`), `POST`/`PUT` create or upload (e.g., S3's `PutObject`), `DELETE` removes. Understanding this reframes "learning AWS" as "learning which API calls exist and what they do" — the Console, CLI, and SDK are just three ways to trigger the same calls.

**Pricing fundamentals — 3 main cost drivers:**
1. **Compute** — charged by resource amount × duration (e.g., EC2 billed per minute while running; stop the instance and compute charges stop, though storage charges may continue).
2. **Storage** — charged by amount stored (S3: pay for actual data stored) or amount *allocated* (EBS: pay for the full provisioned volume size, even if mostly empty).
3. **Outbound data transfer** — you never pay to bring data *into* AWS, but you do pay to move data *out* of an AZ or region. This is a common place companies get surprised by their bill.

**3 pricing models:**
- **Pay-as-you-go (on-demand)** — the default; maximum flexibility, no commitment.
- **Save when you reserve** — commit to 1 or 3 years (with more upfront payment = bigger discount, up to ~75% off on-demand) in exchange for a locked-in lower rate.
- **Pay less when you use more** — volume-tiered discounts (e.g., S3: the per-GB rate drops as your total stored volume crosses certain thresholds).

**The 6 advantages of cloud computing (AWS's own official framing):**
1. Trade capital expense (CapEx) for variable expense (OpEx).
2. Massive economies of scale (AWS's aggregated buying power/efficiency gets passed to you).
3. Stop guessing capacity (no more over-provisioning "just in case").
4. Increase speed and agility.
5. Stop spending money running/maintaining data centers — redirect that budget into building your product instead.
6. Go global in minutes.

### Quick Recap — Part 2
- Global Infrastructure hierarchy: Region → Availability Zone → Subnet, all interconnected by AWS's private global network; plus Outposts/Local Zones/Wavelength Zones for specialized latency needs.
- Shared Responsibility: AWS secures the cloud; you secure what's *in* the cloud (data, access, patching, network config).
- Everything on AWS is ultimately an HTTP API call.
- Pricing = compute (time) + storage (volume) + outbound transfer; choose on-demand / reserved / volume-discount based on your usage pattern.

---

## Part 3 — AWS Authentication and Access Control

### Core Concepts

**IAM (Identity and Access Management)** is the service governing *who* can do *what* on your account.

**Authentication vs. Authorization:**
- **Authentication** = proving you are who you say you are (e.g., password, access keys).
- **Authorization** = once authenticated, what you're actually *allowed* to do — governed by **policies**.

**Core IAM building blocks:**

| Component | Purpose |
|---|---|
| **User** | An individual identity that can log in (console) or authenticate programmatically (access keys); **has zero permissions by default** |
| **Group** | A collection of users — attach a policy once to the group, and every member inherits it (huge management win vs. per-user policies) |
| **Policy** | A JSON document defining allowed/denied actions on resources; attached to users, groups, or roles |
| **Role** | An identity *without* a fixed owner — it's *assumed* temporarily (like "putting on a hat") to gain a specific set of permissions, then given back when done |

**Why roles matter (principle of least privilege):** rather than permanently granting a user powerful permissions they rarely need, give them the ability to **assume a role** (via the `sts:AssumeRole` action) only when needed, then switch back to their low-privilege identity afterward. This limits the blast radius if credentials are ever compromised.

**Root user vs. IAM user:**

| | Root user | IAM user |
|---|---|---|
| Created how | Automatically, from account signup email | Manually, by an admin |
| Default permissions | Full, mostly un-restrictable | **None** — must be explicitly granted |
| Best practice | Avoid daily use; strong password + MFA | Use for everyday work |

**IAM Identity Center** (successor to "AWS SSO") is a *different, complementary* tool:

| | IAM | IAM Identity Center |
|---|---|---|
| Scope | AWS resources/services only | Single sign-on across **multiple AWS accounts** *and* external business apps (Salesforce, Office 365, etc.) |
| Federation | Supported (SAML/OIDC) but more manual setup | Built-in, streamlined federation |
| Best for | Fine-grained, resource-level AWS permissions | Centralized identity management in multi-account or enterprise environments |

**Hands-on labs in this Part cover:** creating IAM users and groups with attached policies; practicing **switching roles** (and specifically granting the `sts:AssumeRole` permission needed to do so); setting up IAM Identity Center for centralized SSO.

### Quick Recap — Part 3
- IAM = authentication (who are you) + authorization (what can you do, via policies).
- Users start with zero permissions; groups let you manage permissions at scale; roles are temporarily "assumed" for least-privilege access.
- IAM Identity Center extends single sign-on beyond AWS into multi-account and third-party business apps.

---

## Part 4 — Amazon EC2, Auto Scaling, and Load Balancing

### Core Concepts

**Server virtualization (the foundation under EC2):** a **hypervisor** (e.g., VMware, Xen, KVM, Hyper-V) sits between physical hardware and multiple **virtual machines**, each with its own OS. This is what lets AWS run many customers' isolated virtual servers ("instances") on shared physical hardware — with benefits like portability (VMs can move between physical hosts), better resource utilization (lower cost), and fast deployment.

**Stateful vs. stateless applications** — an important distinction before talking about scaling:
- **Stateless** — no server-side memory of prior interactions (e.g., a weather-lookup page).
- **Stateful** — the server *does* retain session/user data (e.g., an e-commerce cart, unless externalized to cookies/a database).

**Scaling Up vs. Scaling Out:**

| | Scaling Up (Vertical) | Scaling Out (Horizontal) |
|---|---|---|
| How | Add more CPU/RAM to *one* instance (e.g., switch instance type) | Add *more instances* running the same app, load balanced |
| Fits well for | Things resistant to easy horizontal splitting, e.g. write-heavy relational databases | Stateless workloads, e.g. web tiers behind a load balancer |
| AWS's general preference | — | **Preferred** — spreads risk, more resilient to single-instance failure |
| Requirement for dynamic apps | — | Must first **externalize state** (move session/data out of the instance into something like EFS, DynamoDB, or RDS) so any instance can serve any request |

**High Availability vs. Fault Tolerance** — commonly confused, worth pinning down precisely:

| | High Availability | Fault Tolerance |
|---|---|---|
| Goal | *Minimal* service interruption | **Zero** service interruption, even mid-failure |
| Replication | Synchronous or asynchronous (async is faster, but risks small data loss on failure) | Synchronous only (to guarantee zero data loss) |
| Cost | Lower | Higher (needs specialized redundant hardware) |
| AWS examples | Elastic Load Balancing, Auto Scaling, Route 53 | RAID 1 disk mirroring, redundant NICs, synchronous DB replication, redundant power |
| Who handles most of it on AWS | You configure it using AWS services | AWS handles most of it for you at the infrastructure layer (durable storage, redundant power/network) |

**Durability vs. Availability** (another frequently confused pair):
- **Durability** = protection against data *loss/corruption* (e.g., S3's "11 nines" — expect to lose ~1 object per 10 million objects per 10,000 years).
- **Availability** = the percentage of *time* your data is actually *accessible* (e.g., "99.99%").

**Amazon EC2 Auto Scaling** — automatically launches/terminates instances to (a) maintain availability (replace unhealthy instances) and (b) match capacity to demand (scale out/in).

- Integrates with **CloudWatch** (metrics like CPU utilization feed scaling decisions via alarms), **Elastic Load Balancing** (new instances are automatically registered with the load balancer), **EC2 Spot Instances** (for cost optimization), and **VPC** (deploys across AZs/subnets).
- Configuration lives in a **launch template** (which AMI, instance type, EBS volumes, IAM instance profile, etc. — the newer, more flexible replacement for the older "launch configuration").
- **Health checks**: EC2 status checks + optional ELB health checks (so Auto Scaling also reacts to load-balancer-detected failures, not just instance-level ones), plus a configurable **health check grace period** so new instances aren't judged unhealthy before they've finished booting/initializing.
- **4 scaling types**: manual, dynamic (reacts to real-time metrics), predictive (uses ML to forecast demand ahead of time), and scheduled (scale ahead of known demand patterns, e.g. 9am Monday traffic).

**Amazon Elastic Load Balancing (ELB)** — a single stable endpoint (DNS name) distributing traffic across a target pool. Targets can be EC2 instances, containers, IP addresses, or even Lambda functions. Uses configurable **health checks** to stop routing to failed targets, and (via integration with Auto Scaling) can trigger replacement of unhealthy instances.

**3 load balancer types**, each at a different OSI layer:

| Type | Layer | Best for |
|---|---|---|
| **Application Load Balancer (ALB)** | 7 (HTTP/HTTPS) | Web apps needing path/host-based routing; microservices; container and Lambda targets |
| **Network Load Balancer (NLB)** | 4 (TCP/UDP) | Extremely high performance, ultra-low latency, static IPs, TLS offloading at scale |
| **Gateway Load Balancer (GWLB)** | Network appliance layer | Deploying/scaling third-party virtual appliances (firewalls, IDS/IPS, deep packet inspection) via the Geneve protocol |

**Hands-on labs in this Part cover:** launching Linux and Windows EC2 instances (choosing instance type + AMI + key pair); connecting to instances; working with access keys vs. IAM roles attached to EC2; creating an Application Load Balancer in front of an Auto Scaling group; configuring a scaling policy and testing it under load.

### Quick Recap — Part 4
- EC2 = virtual servers via hypervisor-based virtualization.
- Scale up (vertical, one bigger box) vs. scale out (horizontal, more boxes) — AWS generally prefers scaling out for resilience, but scaling out requires stateless (or externalized-state) apps.
- High Availability (minimal interruption, cheaper) ≠ Fault Tolerance (zero interruption, pricier); Durability (no data loss) ≠ Availability (accessible when needed).
- Auto Scaling maintains availability + matches capacity to demand, driven by CloudWatch metrics/alarms and integrated with ELB.
- ALB (L7, HTTP-aware) / NLB (L4, ultra-fast TCP/UDP) / GWLB (virtual appliances) — pick based on protocol and use case.

---

## Part 5 — Amazon Virtual Private Cloud (VPC)

### Core Concepts

**Networking primer — Routers, Switches, Firewalls:**
- **Switch** (Layer 2) — connects devices *within* the same IP network.
- **Router** (Layer 3) — forwards traffic *between* different IP networks, guided by a routing table.
- **Firewall** — inspects traffic against rule tables to allow/deny it; can sit at different layers of inspection depth (basic IP/port filtering vs. deep application-layer inspection) and at different points in the network (perimeter, per-instance like EC2 Security Groups, or per-subnet like Network ACLs).

**IP Addressing essentials:**
- IPv4 addresses are written in dotted-decimal notation (e.g., `192.168.0.1`), but under the hood each of the 4 octets is 8 binary bits.
- An address splits into a **Network ID** (shared by every host on that network) and a **Host ID** (unique per device), determined by the **subnet mask** — e.g., `/24` means the first 24 bits are the network portion.
- **Private IP ranges** (RFC 1918, not routable on the public internet, ideal for internal cloud networking): `10.0.0.0/8`, `172.16.0.0/12`, `192.168.0.0/16`.
- **CIDR (Classless Inter-Domain Routing)** notation (`x.x.x.x/n`) is how you'll see IP ranges written throughout AWS — understanding binary/subnetting is essential for correctly sizing a VPC and its subnets.

**Amazon VPC — your logically isolated virtual network:**
- Created within a single **region**; isolated from other VPCs/accounts by default.
- You define an overall **CIDR block** for the VPC, then carve out **subnets** — each subnet maps to exactly *one* Availability Zone (a subnet never spans AZs), and each subnet's CIDR is a *subset* of the VPC's block with a *longer* (more specific) subnet mask.
- **Route tables** control how traffic flows within the VPC and out to the internet/elsewhere — configured indirectly (there's no visible "router" object; the route table *is* your configuration surface for the underlying router).
- An **Internet Gateway** attached to the VPC + a route to it (`0.0.0.0/0 → IGW`) enables internet connectivity for public subnets.

**Public vs. Private "space" on AWS:**
- Some services live **inside** a VPC (EC2, RDS, EFS) — private space, under your network control, even if a resource inside has a public IP.
- Some services live **outside** a VPC entirely (e.g., S3) — public space, with public HTTPS endpoints directly reachable over the internet (though still governed by IAM/bucket permissions).
- To reach a public-space service like S3 from a *private* subnet without routing traffic over the public internet, you can use a **VPC (Gateway) Endpoint** — keeping traffic on private AWS networking for better security.

**Security Groups vs. Network ACLs** — both are VPC firewalls, but different in important ways:

| | Security Group | Network ACL (NACL) |
|---|---|---|
| Applies at | Instance level (technically the network interface) | Subnet level |
| Statefulness | **Stateful** — return traffic auto-allowed if inbound was allowed | **Stateless** — must explicitly allow both directions |
| Rule types | Allow only (implicit deny for everything else) | Allow *and* deny rules |
| Rule evaluation | All rules evaluated together | Rules processed **in numbered order**, stops at first match |
| Scope of effect | Only the instances explicitly associated | Every instance in the associated subnet |
| Sees intra-subnet traffic? | Yes (between instances) | No (only traffic entering/leaving the subnet) |

**Cloud deployment models** (distinct from *service* models like IaaS/PaaS/SaaS from Course 2's context):

| Model | Description |
|---|---|
| **Private cloud** | You build/manage everything yourself (e.g., on VMware/OpenStack) — full control, but high capital + operational cost |
| **Public cloud** | AWS/Azure/GCP — pay-as-you-go, massive elasticity, but shared infrastructure |
| **Hybrid cloud** | Connecting private + public via VPN or a private link (e.g., AWS Direct Connect) |
| **Multi-cloud** | Using 2+ public/private cloud providers simultaneously — flexibility at the cost of added complexity |

**AWS VPN vs. AWS Direct Connect** — two ways to connect an on-premises network to a VPC:

| | Site-to-Site VPN | Direct Connect |
|---|---|---|
| Connectivity | Encrypted tunnel over the **public internet** (IPSec) | **Dedicated physical fiber** connection (1 Gbps–100 Gbps) via a Direct Connect location |
| Setup speed | Fast — mostly configuration | Slower — requires physical cross-connects, often via a partner |
| Performance | Good, but subject to public internet variability | Consistent, predictable latency/bandwidth |
| Cost | Lower | Can be higher, depends on volume/redundancy needs |
| Components | Virtual Private Gateway (AWS side) + Customer Gateway (on-prem side config) | AWS cage + customer/partner cage physically cross-connected at a DX location |

**Hands-on labs in this Part cover:** creating a custom VPC (both via the guided wizard and manually — CIDR block, public/private subnets across AZs, internet gateway, route tables); configuring and testing Security Groups and NACLs.

### Quick Recap — Part 5
- Switches connect within a network (L2); routers connect between networks (L3); firewalls filter based on rule tables.
- A VPC has a CIDR block, subdivided into per-AZ subnets, governed by route tables and (optionally) an internet gateway.
- Some AWS services live inside a VPC (private space); others (like S3) live outside it (public space) — VPC endpoints bridge the two privately.
- Security Groups (instance-level, stateful, allow-only) vs. NACLs (subnet-level, stateless, allow+deny, ordered rules).
- VPN (fast to set up, over the internet) vs. Direct Connect (dedicated fiber, more consistent performance) for hybrid connectivity.

---

## Part 6 — AWS Storage Services

### Core Concepts

**3 storage paradigms — the foundational distinction for this entire Part:**

| Type | What it looks like | Mounted as | Example AWS service |
|---|---|---|---|
| **Block storage** | Raw disk (HDD/SSD) — OS partitions/formats it | A local-feeling volume/drive | Amazon EBS |
| **File storage** | A shared file system (over a network protocol like NFS) | A network drive, mountable by many clients simultaneously | Amazon EFS |
| **Object storage** | Files ("objects") in a flat container ("bucket"), accessed via a REST API (HTTP GET/PUT/POST/DELETE) | Not mounted at all — every access is a fresh API call, connection closes right after | Amazon S3 |

Object storage's appeal in the cloud comes from its combination of **API-driven access** (trivial for developers to integrate), **massive scalability**, and **very low cost** — great for everything from backups to logs to media files.

**Amazon EBS (Elastic Block Store)** — the block storage attached to EC2 instances.
- Volumes are provisioned at a fixed size and you pay for that **allocated** capacity, regardless of how full it actually is.
- You can take **snapshots** (point-in-time backups) of a volume, and create new volumes (even in a different AZ) from a snapshot — a common technique for moving data between AZs/instances or building custom AMIs.
- **Instance Store** is a related but different concept — physically-attached, ephemeral storage that's lost when the instance stops/terminates (not covered as deeply, but worth knowing it exists for high-throughput temporary-data use cases).

**Amazon EFS (Elastic File System)** — a managed, Linux-only (NFS-based) shared file system.
- **Regional file system** — mount targets in multiple AZs (an elastic network interface per AZ); instances connect to the mount target in their own AZ for best performance; writes are durably stored across AZs.
- **One Zone file system** — a lower-cost option confined to a single AZ (though it's still reachable cross-AZ if needed).
- **Storage classes**: Standard (SSD-backed, low latency) → Infrequent Access (cheaper, for less-accessed data) → Archive (cheapest, for rarely touched data) — all offering the same "11 nines" of durability as S3.
- Supports **cross-region replication** for disaster recovery (the replica is read-only until you actually fail over) and integrates with **AWS Backup**.
- Two performance modes: **Provisioned throughput** (you specify a fixed performance level regardless of storage size) vs. **Bursting throughput** (scales with the amount of data stored, with the ability to burst higher temporarily).

**Amazon S3 (Simple Storage Service)** — AWS's flagship object storage service.
- Core structure: **bucket** (container, globally-unique name since it's part of a public URL) → **objects** (files, identified by a **key** — essentially a key-value store where the key is the filename and the value is the file data).
- Accessed entirely via **REST API over HTTPS**: `PUT`/`POST` to upload, `GET` to download, etc. — this is why it's so friendly for developers and for any SDK-driven workflow.
- **No real hierarchy** — S3 is a flat namespace. "Folders" you see in the console are purely a *visual* mimicry created by using `/` characters as a **prefix** within the key itself (e.g., `my-documents/raspberry.jpeg` — the whole string is the actual key; S3 itself doesn't understand "folders").
- Because S3 lives in AWS's **public space** (outside any VPC), traffic from a VPC to S3 normally goes out through an Internet Gateway (or NAT Gateway for private subnets) — but you can instead use an **S3 Gateway Endpoint** (a type of VPC endpoint) to reach S3 over private AWS networking instead, for both security and (often) cost reasons.
- Supports **static website hosting** directly from a bucket (HTTP only — for HTTPS, you'd front it with CloudFront, covered in Part 9).

**File storage vs. Object storage — the classic comparison:**

| | File storage (EFS) | Object storage (S3) |
|---|---|---|
| Organization | Real directory hierarchy | Flat namespace, hierarchy mimicked via key prefixes |
| Access model | Mounted, persistent connection, works like local storage | REST API call per operation, no persistent mount |
| Best for | Shared application file access, POSIX-style workloads | Massive-scale, cost-effective storage of any file type, backups, static content, data lakes |

**Hands-on labs in this Part cover:** creating and attaching EBS volumes, taking snapshots and restoring them into new volumes/AZs; creating S3 buckets, uploading/downloading objects, mimicking folder hierarchy with prefixes, setting a public bucket policy; hosting a static website directly on S3.

### Quick Recap — Part 6
- Block (raw disk, e.g. EBS) / File (shared network file system, e.g. EFS) / Object (flat, API-driven bucket store, e.g. S3) are the three fundamental storage paradigms on AWS.
- EBS: pay for allocated size; snapshots enable backup/AZ migration.
- EFS: Linux-only NFS shares, regional or one-zone, tiered storage classes, cross-region DR replication.
- S3: globally-unique bucket names, flat key-value namespace (folders are a UI illusion via prefixes), fully REST/API-driven, lives outside the VPC (use a Gateway Endpoint for private access).

---

## Part 7 — AWS Database Services

### Core Concepts

**Relational vs. Non-Relational — the fundamental database split** (echoing Course 1's SQL vs. NoSQL, now mapped onto specific AWS services):

| | Relational (SQL) | Non-Relational (NoSQL) |
|---|---|---|
| Structure | Tables, rows, columns; **rigid, predefined schema** | Key-value, document, column, or graph; **flexible schema** |
| Scaling | Primarily **vertical** (though sharding/partitioning can achieve horizontal scale with added complexity) | **Horizontal**, natively |
| AWS example | Amazon RDS (MySQL, PostgreSQL, MariaDB, Oracle, SQL Server, Aurora) | Amazon DynamoDB |
| Other examples | Oracle, IBM Db2, PostgreSQL | MongoDB, Redis, Neo4j |
| Best for | Structured data, complex queries/joins, strict consistency | Unstructured/variable data, extreme scale, simple fast lookups |

**Graph databases** (e.g., Amazon Neptune) are a specialized non-relational type — nodes represent entities, edges represent relationships, properties store attributes on either. Ideal for tightly-interconnected data like social networks or recommendation graphs.

**Operational (OLTP) vs. Analytical (OLAP)** — a second, independent axis, cutting across relational/non-relational:

| | Operational / OLTP | Analytical / OLAP |
|---|---|---|
| Purpose | Live, transactional production data (e.g., orders being placed right now) | Complex queries/trends across large aggregated datasets, often sourced *from* OLTP systems |
| Query style | Short transactions, simple queries | Long-running, complex queries |
| AWS relational example | Amazon RDS | Amazon Redshift |
| AWS non-relational example | MongoDB, Cassandra, Neo4j, HBase | Amazon EMR (Elastic MapReduce) |

**AWS database service overview:**

| Service | When to use |
|---|---|
| **Database on EC2** | You need *full control* over the OS and DB engine (including unsupported third-party engines RDS doesn't offer) |
| **Amazon RDS** | You need a relational database and don't want to manage the underlying OS/patching — supports multiple engines including Aurora |
| **Amazon DynamoDB** | You need a NoSQL database with fast, predictable performance, high I/O, and dynamic scaling |
| **Amazon Redshift** | You need a data warehouse for analytics across aggregated OLTP data |
| **Amazon ElastiCache** | You want to speed up reads by caching data in memory in front of another database (often paired with RDS) |

**Amazon RDS specifics** (from the hands-on lab): choose an engine (e.g., MySQL, or AWS's preferred Aurora), an instance class, and storage type; can deploy **Multi-AZ** for a primary + standby replica setup (redundancy); can create **read replicas** (separate endpoint, read-only, asynchronously replicated — useful for scaling read-heavy workloads); credentials can be managed via **Secrets Manager** so applications reference a secret rather than hardcoding connection details (making failover transparent to the app).

**Amazon DynamoDB specifics:**
- Fully managed, **serverless** NoSQL — no instances to manage.
- A **key-value or document store**; data organized into **tables → items (≈ rows) → attributes (≈ columns, but flexible per item)**.
- Data is automatically **partitioned** and replicated across multiple AZs for durability and performance; scaling adjusts partitioning with **zero downtime**.
- **DynamoDB Streams** capture a time-ordered log of item-level changes — commonly consumed by a Lambda function to react to data changes (a direct DynamoDB analog to Course 2's Event Sourcing / CQRS patterns).
- Supports both **eventually consistent** and **strongly consistent** reads, and even ACID transactions when needed.
- **Global Tables** — fully managed, multi-region, multi-master replication: read/write from multiple regions with data syncing both ways (five-nines availability SLA vs. four-nines for a single-region table).
- Pricing: **provisioned throughput** (you specify expected read/write capacity — cost-efficient for steady, predictable load) vs. **on-demand** (pay for what you use — better for unpredictable/variable load), plus storage and add-on feature costs.
- Query patterns: a **partition key** (must be unique per item, or unique combined with a **sort key**) drives fast lookups via the **Query** API; a **Scan** reads the whole table (optionally filtered) — much less efficient at scale. **Global Secondary Indexes** let you efficiently query on non-primary-key attributes.

**Hands-on labs in this Part cover:** creating an RDS MySQL database (including a read replica); creating a DynamoDB table, batch-loading items via the CLI, and practicing Scan vs. Query API calls with different filter conditions.

### Quick Recap — Part 7
- Relational (rigid schema, vertical scaling, RDS) vs. Non-relational (flexible schema, horizontal scaling, DynamoDB) is one axis; Operational/OLTP vs. Analytical/OLAP is a separate, orthogonal axis.
- RDS = managed relational DB; DynamoDB = fully serverless NoSQL with automatic partitioning, Streams for change events, and Global Tables for multi-region active-active.
- Prefer Query (uses the key) over Scan (reads everything) in DynamoDB for performance at scale.

---

## Part 8 — Automation and DevOps on AWS

### Core Concepts

**AWS CloudFormation — Infrastructure as Code (IaC):**
- You define your desired infrastructure in a **template** file (JSON or YAML — YAML is generally easier to read) — analogous to Terraform, but AWS-native only.
- Deploying a template creates a **stack** — the live set of resources described by that template. Delete the stack, and (by default) CloudFormation tears down everything it created — clean, reliable rollback.
- A **StackSet** extends this to deploy/update/delete the same stack across **multiple accounts and regions** in one operation.
- **Change Sets** let you preview exactly what a template update *would* change before actually applying it — a critical safety net that prevents accidental infrastructure damage.
- Core value proposition: **reusability + consistency** — the same template reliably produces the same infrastructure every time, eliminating manual configuration drift and human error.

**AWS Elastic Beanstalk — Platform as a Service (PaaS):**
- Recall the IaaS vs. PaaS distinction: with **IaaS** (e.g., raw EC2), you manage the OS, runtime, and patches yourself. With **PaaS** (Beanstalk), you just **upload your code** (as a zip file) and Beanstalk provisions and manages everything underneath — EC2 instances, an Auto Scaling group, a load balancer — while still giving you OS-level access if you specifically need it.
- Supports many platforms/languages: Java, .NET, Node.js, PHP, Ruby, Python, Go, Docker.
- Structure: **Application** (the top-level container) → **Application Versions** (each upload of your code, stored in S3, individually re-deployable/rollback-able) → **Environments** (an application version actually deployed and running on provisioned AWS resources — you can have separate dev and production environments, each running a different version).
- **Web tier vs. Worker tier**: web environments handle incoming HTTP(S) requests directly (typically behind a load balancer); worker environments poll an **SQS queue** for background/long-running tasks — a direct application of the "decouple slow work behind a queue" pattern from Course 2's Message Broker / Pipes-and-Filters concepts.

**CI/CD (Continuous Integration / Continuous Delivery) with AWS Developer Tools:**
The classic DevOps loop — plan → code → build → test → release → deploy → operate → monitor → (repeat) — is automated end-to-end using AWS's "Code" family of tools:

| Tool | Role |
|---|---|
| **CodeCommit** | Git-compatible source repository (developer pushes code here, like GitHub) |
| **CodeBuild** | Build server — compiles/builds and runs tests against the code, reports pass/fail |
| **CodeDeploy** | Deploys the built, tested code out to target compute (EC2, Lambda, ECS) or via CloudFormation |
| **CodePipeline** | Orchestrates the whole flow — automatically triggers CodeBuild on a new commit, then CodeDeploy once tests pass |

The result: a developer commits code, and — fully automated — it's built, tested, and (if it passes) deployed, with no manual intervention required at any step.

**Hands-on labs in this Part cover:** creating and updating a CloudFormation stack from a YAML template (including deploying a VPC via CloudFormation — tying Part 5's concepts to IaC); deploying an application through Elastic Beanstalk; wiring up CodePipeline with Elastic Beanstalk as the deployment target for an automated release pipeline.

### Quick Recap — Part 8
- CloudFormation = Infrastructure as Code — templates define stacks, Change Sets preview updates safely, StackSets scale across accounts/regions.
- Elastic Beanstalk = PaaS — upload code, AWS manages the underlying EC2/ASG/load-balancer infrastructure; Applications → Versions → Environments; web tier (HTTP) vs. worker tier (SQS-polling background jobs).
- CI/CD via CodeCommit (repo) → CodeBuild (build/test) → CodeDeploy (release), automated end-to-end by CodePipeline.

---

## Part 9 — DNS, Caching, and Performance Optimization

### Core Concepts

**Bandwidth vs. Latency** — two different performance measures, easy to conflate:
- **Bandwidth** = how much data you can push through per unit time (e.g., Gbps) — think "width of the pipe."
- **Latency** = how long it takes data to travel from A to B (ms/µs) — driven primarily by **distance**, but also affected by propagation delay, transmission delay, queuing delay (time waiting in device queues), and processing delay (time each router/switch hop takes to forward the packet).
- Some applications are latency-sensitive (voice calls, gaming) but not bandwidth-sensitive; others are the reverse (large file downloads).

**DNS and Amazon Route 53:**
- DNS translates human-friendly domain names into IP addresses that computers actually use to route traffic — a **DNS query** asks "what's the IP for this domain," resolved via a **zone file** (or recursively forwarded to other DNS servers if not known locally).
- **Route 53** is AWS's DNS service — but it goes beyond plain DNS with *intelligent routing* capabilities (which specific answer to give depends on health, latency, geography, weighting, etc. — not covered in exhaustive depth here, but flagged as a key differentiator from "dumb" DNS).
- Route 53 can also **register domains** directly.

**Amazon CloudFront (CDN):**
- Solves the same fundamental problem as YouTube/Vimeo's own CDNs: content physically located in one place is slow for globally distributed users. CloudFront caches content at **edge locations** worldwide (hundreds of them), so users are served from the nearest cache rather than the origin.
- A CloudFront **distribution** has an **origin** (where the real content lives — an S3 bucket, or an EC2/ALB-backed web server) and gets replicated out to **regional edge caches** (fewer, higher-capacity) and **edge locations** (many, closer to end users).
- All the "backend" hops (origin ↔ regional cache ↔ edge location) travel over AWS's private **global network** — only the final hop from edge location to end user crosses the public internet, which is why CloudFront meaningfully cuts latency.
- Delivers both static and dynamic content, supports live streaming and video-on-demand.
- **Lambda@Edge** lets you run custom code at 4 points in the request/response cycle (viewer request → origin request → origin response → viewer response) — e.g., to inspect, transform, or redirect requests closer to the user rather than at the origin.
- Security integrations: **AWS Certificate Manager** (SSL/TLS certs for HTTPS), **AWS Shield** (DDoS protection), **AWS WAF** (Web Application Firewall rules), plus content-level protections like signed URLs/cookies and Origin Access Control (restricting direct access to the origin, forcing traffic through CloudFront).

**AWS Global Accelerator:**
- Also leverages the CloudFront edge-location network, but for a different purpose: instead of caching *content*, it accelerates *connections* to your application (e.g., load balancers in multiple regions) by routing user traffic onto the AWS global network as early as possible (at the nearest edge location) rather than staying on the public internet the whole way.
- Provides **static Anycast IP addresses** as a fixed entry point — the same IP addresses are simultaneously "present" at multiple global locations, and internet routing naturally sends each user to their nearest one.
- Operates at **Layer 4** (network layer) and supports **TCP and UDP** — this is its key differentiator from CloudFront, which is **HTTP/HTTPS only**. Use CloudFront for web content (port 80/443); use Global Accelerator for anything else (custom TCP/UDP ports, gaming, VoIP, IoT, etc.).
- Performs health checks and automatically re-routes users to the next-best healthy regional endpoint if their closest one fails — a built-in disaster-recovery mechanism.

### Quick Recap — Part 9
- Bandwidth = pipe width (throughput); Latency = travel time (mostly distance-driven, plus queuing/processing delays).
- Route 53 = intelligent DNS (+ domain registration).
- CloudFront = CDN, caches content at edge locations, HTTP/HTTPS only, integrates with Shield/WAF/ACM for security, Lambda@Edge for request/response customization.
- Global Accelerator = accelerates any TCP/UDP traffic (not just HTTP) to multi-region endpoints via static Anycast IPs and the AWS global network backbone.

---

## Part 10 — Containers and Serverless Computing

### Core Concepts

**Docker Containers vs. Virtualization:**
- Traditional virtualization: hypervisor → multiple VMs, **each with its own full OS** — heavy overhead (patching, resource use) per VM.
- Containers: one shared host OS → Docker Engine (a container runtime layer) → multiple **containers**, each packaging just the app code + its dependencies, **sharing the host's OS kernel**. Result: much lighter weight, far faster startup, more resource-efficient than full VMs.
- **Docker Hub** — a cloud registry for storing/sharing container images.

**Microservices & Cloud-Native Applications:**
- A cloud-native app decomposes into **loosely coupled components** (e.g., separate customer, cart, auth, payment services), each independently deployable and scalable, communicating over **APIs**, often via message queues/topics for decoupling.
- Key benefits: independent scaling per component, independent tech-stack choices per team/service, faster/safer deployments (updating one service doesn't require touching others), and better fault isolation — this directly echoes the Microservices Architecture pattern from Course 1 and the Backends-for-Frontends-style extensibility thinking from Course 2, now mapped onto concrete AWS building blocks (ECS containers, Lambda functions, API Gateway, SQS, DynamoDB, SNS).

**Amazon ECS (Elastic Container Service):** AWS's service for running Docker containers.
- Core structure: **Cluster** → **Task Definition** (blueprint: which container image, CPU/memory, networking) → **Task** (a running instance of that definition) → optionally a **Service** (keeps a specified number of tasks running continuously, can attach a load balancer and auto-scaling).
- **AWS Fargate** is the serverless launch mode for ECS — you don't manage or provision any underlying EC2 instances at all; you just specify the task and Fargate runs it.

**Serverless Computing & Event-Driven Architecture:**
- "Serverless" doesn't mean no servers — it means **you don't manage them**: no provisioning, patching, OS/runtime management, or capacity planning. You bring code/configuration; AWS handles scaling and availability, often at very low cost since you pay per invocation/use rather than for idle capacity.
- Combined with **event-driven architecture** (direct parallel to Course 2's Event-Driven Architecture pattern): an action in one service (e.g., a file upload to S3) automatically triggers the next step in a chain (e.g., an S3 **event notification** invokes a **Lambda function**, which processes the file, drops a message in an **SQS queue**, which triggers another Lambda, which writes results to **DynamoDB** and notifies via **SNS**) — a fully automated pipeline with zero manual orchestration.

**AWS Lambda** — the flagship serverless compute service:
- A **function** runs code in response to a **trigger** (an event); you pay based on **memory allocated × execution duration** — and pay nothing while the function is idle.
- Supports many runtimes (Python, Node.js, Java, Go, PowerShell, C#, Ruby...).
- The **execution role** (an IAM role) grants the function permission to interact with other AWS services — a function can only do what its role explicitly allows (e.g., write to CloudWatch Logs, put items in DynamoDB).
- Max execution time: **15 minutes** per invocation.
- **Synchronous invocation** — caller waits for a response (success/failure known immediately). **Asynchronous invocation** — Lambda queues the event and returns immediately; the caller doesn't wait to learn the outcome.
- **Horizontal scaling** — Lambda runs many concurrent invocations in parallel automatically, up to your account/function's concurrency limit.
- Lambda functions are **regional** and have no VPC access by default; to reach VPC resources (like a private RDS database), you explicitly connect the function to specific subnets/security groups (Lambda creates an elastic network interface there) — and if the function *also* needs internet access from inside the VPC, you need a **NAT Gateway** in a public subnet.

**Application Integration Services** — the "glue" connecting event-driven components:

| Service | Model | Best for |
|---|---|---|
| **SQS (Simple Queue Service)** | Pull-based, store-and-forward message queue | Decoupling producer/consumer speed mismatches — e.g., absorbing a traffic spike so a slower backend doesn't lose orders while it scales up |
| **SNS (Simple Notification Service)** | Push-based, publish/subscribe | Fanning one message out to many subscribers (email, SMS, Lambda, SQS, HTTP endpoints, etc.) simultaneously |
| **Step Functions** | Orchestration | Coordinating multi-step workflows across multiple Lambda functions with defined logic/branching |
| **Amazon MQ** | Managed message broker (Apache ActiveMQ/RabbitMQ compatible) | Migrating existing on-prem apps that already use these standard protocols, without rewriting messaging code |
| **EventBridge** | Serverless event bus | Ingesting events from AWS services, custom apps, or SaaS apps; filtering/routing via rules to many possible targets |

SQS vs. SNS is the pairing most worth internalizing: **SQS = pull, one consumer processes each message** (decoupling by buffering); **SNS = push, many subscribers all receive each message** (decoupling by broadcasting) — this maps directly onto the message-broker and pub/sub concepts from Course 1's Message Broker lecture and Course 2's Choreography pattern.

**Amazon API Gateway:**
- Provides a single, public HTTPS endpoint in front of a collection of backend microservices (Lambda functions, ECS containers, HTTP backends, DynamoDB, etc.) — this is a direct, concrete implementation of the **API Gateway architectural pattern** from Course 1.
- Structure: **Resources** (URL paths, e.g. `/orders`, `/payment`) → **Methods** (HTTP verbs like GET/POST attached to each resource) → **Integrations** (which backend actually handles that method — often a **proxy integration**, meaning API Gateway passes the request through unmodified rather than transforming it).
- Deployed to a **stage** (e.g., `prod`), which becomes part of the invoke URL.
- **CORS (Cross-Origin Resource Sharing)** must be explicitly enabled when your API is called from a *different* origin than where it's hosted (e.g., a static S3-hosted website calling the API) — a very common practical gotcha.

**Amazon EventBridge (in more depth):** a serverless event bus that can ingest events from AWS services (e.g., "EC2 instance terminated," or CloudTrail-logged API actions like "S3 bucket policy changed"), apply configurable **rules** to filter/route them, and deliver matches to targets like Lambda, SNS, SQS, or Kinesis. Scales automatically to millions of events/second. Useful both for automated remediation (e.g., auto-fixing an insecure S3 bucket policy the moment it's detected) and for simple alerting/auditing.

**Hands-on labs in this Part cover:** launching Docker containers on ECS/Fargate (task definitions, tasks, and services); building a Lambda function that writes to CloudWatch Logs and is triggered both manually (CLI/test event) and automatically (S3 event notification); building a full serverless REST API application — API Gateway (with CORS) → Lambda (proxy integration) → SQS → Lambda → DynamoDB, fronted by a static S3 website that submits real orders end-to-end.

### Quick Recap — Part 10
- Containers share a host OS kernel (lightweight, fast) vs. VMs which each run a full OS (heavier) — Docker packages app + dependencies into portable images.
- ECS runs containers; Fargate is the serverless (no EC2 management) launch mode.
- Serverless = AWS manages the infrastructure entirely; you pay only for actual usage — pairs naturally with event-driven architecture.
- Lambda: pay per memory × duration, max 15 min, sync vs. async invocation, execution role controls permissions, VPC access requires explicit configuration (+ NAT Gateway for internet access from inside a VPC).
- SQS (pull, 1 consumer per message, buffering) vs. SNS (push, fan-out to many subscribers) vs. EventBridge (flexible event bus with rule-based routing) vs. Step Functions (multi-step workflow orchestration).
- API Gateway = single HTTPS front door composing multiple backend microservices — a real-world instance of Course 1's API Gateway pattern.

---

## Part 11 — Machine Learning and AI

### Core Concepts

**Using generative AI (e.g., ChatGPT) as a learning and productivity tool:**
- Genuinely useful for immediate, contextual Q&A while learning cloud concepts, generating project ideas, and producing starter code, CLI commands, and CloudFormation templates.
- **Caveats to keep in mind:** training data can be out of date (especially problematic for a fast-moving platform like AWS), models can simply be wrong, and models can "hallucinate" (confidently generate plausible-sounding but incorrect information) — always verify important output rather than trusting it blindly.
- **Good prompting habits:** be clear and specific about what you want, provide context (what you're building and why), specify the desired output format (e.g., "give me a bullet list," "write it in Python," "use YAML"), state exactly which AWS services/architecture you want included, mention any security/best-practice requirements, and iterate — refine your prompt based on what comes back rather than expecting a perfect first answer.
- Reported as particularly reliable for generating CLI command sequences (in the correct order) and reasonably strong (though imperfect and worth double-checking) for CloudFormation templates and Lambda function code.

**AWS Machine Learning and AI services (a sampler, not exhaustive — this space evolves quickly):**

| Service | What it does |
|---|---|
| **Amazon Rekognition** | Image/video analysis — object detection, facial analysis, celebrity recognition; commonly wired into event-driven pipelines (e.g., S3 upload → Lambda → Rekognition → results stored/notified) |
| **Amazon Transcribe** | Speech-to-text via automatic speech recognition |
| **Amazon Translate** | Neural machine translation between languages |
| **Amazon Comprehend** | Natural language processing — extracting sentiment and key information from unstructured text |
| **Amazon Lex** | Conversational AI for building chatbots/voice interfaces (e.g., for contact centers) |
| **Amazon DevOps Guru** | ML-powered operational anomaly detection — flags behavior that deviates from normal patterns, reduces alarm noise |
| **Amazon CodeGuru Security** | ML + automated reasoning to detect, track, and suggest fixes for code security vulnerabilities, integrated into IDEs/CI-CD |

Most of these services are designed to be dropped into **event-driven pipelines** just like the ones in Part 10 — e.g., an image lands in S3 → triggers Lambda → calls Rekognition → result published via SNS → another Lambda stores it in DynamoDB.

**Hands-on lab in this Part covers:** building a pipeline to process and analyze uploaded images/videos using Rekognition, tying together S3, Lambda, and the ML service end-to-end.

### Quick Recap — Part 11
- Generative AI is a genuinely useful learning/productivity accelerator — but always fact-check, especially for anything AWS-specific given how fast the platform changes.
- Good prompts are specific, contextual, and iterative.
- AWS ML/AI services (Rekognition, Transcribe, Translate, Comprehend, Lex, DevOps Guru, CodeGuru Security) are typically consumed the same way as any other AWS service — via API calls wired into event-driven pipelines.

---

## Part 12 — Get Certified on AWS

### Core Concepts

**Why certify:** growing job demand, globally portable skills, strong salaries — and increasingly, certification functions as a *baseline prerequisite* for cloud roles rather than a differentiator on its own. Hands-on experience alongside the certification matters just as much as the credential itself.

**The AWS certification pathway:**

| Level | Certifications | Notes |
|---|---|---|
| **Foundational** | Cloud Practitioner | Recommended starting point for everyone, even those with existing IT backgrounds |
| **Associate** | Solutions Architect, Developer, SysOps Administrator, Data Engineer | Significant jump in difficulty from Foundational; notable overlap between Solutions Architect / Developer / SysOps, so earning one makes the next easier |
| **Professional** | DevOps Engineer Professional, Solutions Architect Professional | Considerably harder — Solutions Architect Professional in particular is widely regarded as one of the toughest AWS exams |
| **Specialty** | Advanced Networking, Security, Machine Learning (and others, which change over time) | Deep expertise in a specific domain — recommended to hold at least one Associate certification first, even if you already have strong domain expertise (e.g., a security professional should still get an Associate cert before the Security Specialty) |

**Recommended path for most learners:** Foundational (Cloud Practitioner) → Solutions Architect Associate (broadest service coverage of the Associate options) → additional Associates or straight to Professional/Specialty depending on your career direction.

### Quick Recap — Part 12
- Certifications are now closer to a baseline job requirement than a pure differentiator — pair them with real hands-on practice.
- Path: Foundational → Associate (Solutions Architect Associate is the broadest, most recommended starting point) → Professional and/or Specialty based on your goals.

---

## 🧠 Master Glossary (quick-reference)

- **Region / Availability Zone (AZ)** — a geographic location / an isolated data center (or group of them) within it.
- **Shared Responsibility Model** — AWS secures the cloud (infrastructure); you secure what's in the cloud (data, access, config, patching where applicable).
- **IAM User / Group / Role / Policy** — identity that logs in / collection of users sharing permissions / temporarily-assumed identity / JSON document defining allowed actions.
- **EC2** — virtual servers ("instances") via hypervisor-based virtualization.
- **Scaling Up (vertical)** vs. **Scaling Out (horizontal)** — bigger single instance vs. more instances load-balanced together.
- **High Availability** (minimal interruption) vs. **Fault Tolerance** (zero interruption, higher cost).
- **Durability** (no data loss) vs. **Availability** (accessible when needed).
- **Auto Scaling** — automatically launches/terminates EC2 instances based on health checks and demand (CloudWatch-driven).
- **Elastic Load Balancing (ALB/NLB/GWLB)** — distributes traffic across targets; ALB = HTTP-aware (L7), NLB = ultra-fast TCP/UDP (L4), GWLB = virtual appliances.
- **VPC** — your logically isolated virtual network, with a CIDR block subdivided into per-AZ subnets.
- **Security Group** (instance-level, stateful, allow-only) vs. **Network ACL** (subnet-level, stateless, allow+deny, ordered).
- **VPN** (encrypted tunnel over the internet) vs. **Direct Connect** (dedicated physical fiber).
- **Block storage** (EBS) / **File storage** (EFS) / **Object storage** (S3) — the three storage paradigms.
- **RDS** — managed relational database service. **DynamoDB** — fully serverless NoSQL database.
- **CloudFormation** — Infrastructure as Code; templates define stacks.
- **Elastic Beanstalk** — PaaS; upload code, AWS manages the underlying infrastructure.
- **CI/CD (CodeCommit/CodeBuild/CodeDeploy/CodePipeline)** — automated build-test-deploy pipeline.
- **Route 53** — DNS service with intelligent routing.
- **CloudFront** — CDN, caches content at edge locations (HTTP/HTTPS only).
- **Global Accelerator** — accelerates any TCP/UDP traffic via static Anycast IPs and the AWS global network.
- **Docker / ECS / Fargate** — containerization; ECS runs containers; Fargate is the serverless (no EC2 management) mode.
- **Lambda** — serverless functions, pay per memory × duration, max 15-minute execution.
- **SQS** (pull-based queue, decoupling) vs. **SNS** (push-based pub/sub, fan-out) vs. **EventBridge** (rule-based event bus) vs. **Step Functions** (workflow orchestration).
- **API Gateway** — single HTTPS front door composing multiple backend services (concrete implementation of the API Gateway pattern).
- **Rekognition / Transcribe / Translate / Comprehend / Lex** — AWS's image, speech-to-text, translation, NLP, and chatbot AI services, respectively.

---

*End of Course 3 study guide — and with it, all three courses are covered. Together they form a natural progression: Course 1 taught you how to **think** about architecture, Course 2 gave you a **toolbox of patterns**, and Course 3 showed you the **concrete AWS services** that implement both. If it's useful, I can also put together a single cross-course "cheat sheet" mapping specific Course 1/2 concepts directly to the AWS services in Course 3 that implement them (e.g., "Message Broker pattern → SQS/SNS", "API Gateway pattern → Amazon API Gateway", "CAP theorem trade-offs → DynamoDB consistency settings").*
