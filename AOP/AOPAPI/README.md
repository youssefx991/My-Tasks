# AOP_CORE — Aspect-Oriented Programming on .NET 10

This is the **.NET 10** port of the original `AOP_Session_End` sample (ASP.NET Web API on
.NET Framework 4.7.2). It demonstrates the same three ways of implementing
cross-cutting concerns (**logging** and **validation**) without polluting business code:

1. **Decorators** — hand-written wrapper classes.
2. **Interceptors** — dynamic proxies (**Castle DynamicProxy**, the modern replacement for Unity Interception).
3. **PostSharp aspect** — compile-time IL weaving (optional, free Community edition).

The same `UserService` is wrapped by whichever technique you select; the business code never
changes.

---

## Requirements

- .NET SDK 10.0+ (`dotnet --version` → `10.x`)

> The repo includes a `nuget.config` that restores **only** from nuget.org, so it ignores any
> private machine/user feeds.

## Build & run

```bash
cd "AOP_CORE"
dotnet build
dotnet run --project AOPAPI
```

Then open the URL printed in the console (e.g. `http://localhost:5164`). The root redirects to
**Swagger UI** (`/swagger`) where you can try every endpoint.

### Endpoints

| Method | Route | Notes |
|--------|-------|-------|
| GET    | `/api/Users`               | list users |
| GET    | `/api/Users/{id}`          | **throws on purpose** to demo exception logging |
| POST   | `/api/Users/Assign`        | body `{ "userId":2, "courseId":1, "paidAmount":100 }` — validated by the aspect |
| GET    | `/api/Courses`             | list courses |
| GET    | `/api/Courses/{id}`        | one course |
| DELETE | `/api/Courses/Delete/{id}` | delete a course |

`UserService.GetById` deliberately throws `new Exception("Test")`. With an aspect active it is
logged and swallowed (you get `204`/`null`); with no aspect (`Direct`) it bubbles up as `500`.
`AssignCourse` has **no** inline validation — validation is added entirely by the aspect.

Logs are written by **log4net** to `AOPAPI/bin/Debug/net10.0/logs/logs-yyyy.MM.dd.txt`.

## Choosing the AOP strategy

Set it in `AOPAPI/appsettings.json`:

```json
"Aop": { "Strategy": "Interceptor" }   // Direct | Decorator | Interceptor
```

or override at runtime:

```bash
# PowerShell
$env:Aop__Strategy="Decorator"; dotnet run --project AOPAPI --no-launch-profile
```

| Strategy      | How aspects attach                          | `GET /Users/1` | invalid `Assign` |
|---------------|---------------------------------------------|----------------|------------------|
| `Direct`      | none (raw service)                          | 500            | `true` (allowed) |
| `Decorator`   | `UserServiceLoggingDecorator` → `…Validation…` | 204 (swallowed)| `false` (blocked)|
| `Interceptor` | Castle proxy `[Logging, Validation]`        | 204 (swallowed)| `false` (blocked)|

---

## How the Unity interceptor was replaced

The original used **Unity** as the IoC container *and* **Unity.Interception** for the proxy
pipeline. On modern .NET the idiomatic container is the built-in
`Microsoft.Extensions.DependencyInjection`, and `Unity.AspNet.WebApi` does not exist for
ASP.NET Core. So two things were swapped:

### 1. Container: Unity → built-in DI

| Original (Unity) | Now (`IServiceCollection`) |
|---|---|
| `container.RegisterType<IUserRepository, UserRepository>(new PerResolveLifetimeManager())` | `services.AddScoped<IUserRepository, UserRepository>()` |
| `UnityConfig.RegisterTypes` | `ServiceCollectionExtensions.AddAopServices` |
| `container.Resolve<IValidator<T>>()` inside services | injected `IServiceProvider.GetService(typeof(IValidator<T>))` |
| `UnityWebApiActivator` / `UnityDependencyResolver` | not needed — controllers resolve from the framework container |

### 2. Interception: Unity.Interception → Castle DynamicProxy

Unity's `IInterceptionBehavior` and Castle's `IInterceptor` are the same idea (wrap a call,
optionally continue), with a different shape:

| Concept | Unity.Interception | Castle DynamicProxy |
|---|---|---|
| Behavior contract | `IInterceptionBehavior` | `IInterceptor` |
| Method hook | `IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)` | `void Intercept(IInvocation invocation)` |
| Continue the pipeline | `getNext()(input, getNext)` | `invocation.Proceed()` |
| Read/replace return value | `input.CreateMethodReturn(value)` / `result.ReturnValue` | `invocation.ReturnValue` |
| Short-circuit (e.g. invalid input) | return a `CreateMethodReturn(...)` without calling `getNext` | set `invocation.ReturnValue` and **don't** call `Proceed()` |
| Build the proxy | `new Interceptor<InterfaceInterceptor>()` + `InterceptionBehavior<T>` registrations | `ProxyGenerator.CreateInterfaceProxyWithTarget<IUserService>(target, interceptors)` |

So the registration

```csharp
// OLD (Unity)
container.AddNewExtension<Interception>();
container.RegisterType<IUserService, UserService>(
    new Interceptor<InterfaceInterceptor>(),
    new InterceptionBehavior<LoggingInterceptor>(),
    new InterceptionBehavior<ValidationInterceptor>());
```

became (see `Infrastructure/ServiceCollectionExtensions.cs`)

```csharp
// NEW (Castle DynamicProxy + MS DI)
services.AddSingleton<IProxyGenerator>(new ProxyGenerator());
services.AddScoped<UserService>();
services.AddScoped<LoggingInterceptor>();
services.AddScoped<ValidationInterceptor>();
services.AddScoped<IUserService>(sp =>
{
    var target = sp.GetRequiredService<UserService>();
    var interceptors = new IInterceptor[]
    {
        sp.GetRequiredService<LoggingInterceptor>(),
        sp.GetRequiredService<ValidationInterceptor>()
    };
    return sp.GetRequiredService<IProxyGenerator>()
             .CreateInterfaceProxyWithTarget<IUserService>(target, interceptors);
});
```

The interceptor bodies map almost line-for-line — compare the original
`Aspects/*/Interceptor/*.cs` with the ported versions. The behavior is identical: logging wraps
the call and swallows exceptions; validation resolves an `IValidator<T>` and short-circuits with
a default return value when the input is invalid.

Other framework swaps made along the way:

- `ApiController` (`System.Web.Http`) → `ControllerBase` (`Microsoft.AspNetCore.Mvc`); `[RoutePrefix]`/`[Route]` → `[Route]`/`[HttpGet("...")]`.
- `Global.asax` + `WebApiConfig` → `Program.cs` (minimal hosting).
- JSON reference-loop handling moved from `GlobalConfiguration...ReferenceLoopHandling` to `AddNewtonsoftJson(...)`.
- `log4net` still used, but configured explicitly from `log4net.config` (Core no longer auto-reads `*.config`).

---

## PostSharp (free version) — install & run

PostSharp does AOP **at compile time**: its build task rewrites the IL of every method the
aspect targets. It is **optional** here and **off by default** so the project builds with no
license. The aspect lives in `Aspects/Logging/PostSharp/LoggingAspect.cs`, guarded by
`#if POSTSHARP`, and is applied with `[LoggingAspect]` on `UserService`.

### 1. Get the free license (PostSharp Community)

1. Go to **https://www.postsharp.net/get/free** and register — you get a free **Community**
   license key by email (no cost). Community supports the aspect framework used here
   (`OnMethodBoundaryAspect`) for a small number of types, which is plenty for this sample.

### 2. The package is already referenced (conditionally)

`AOPAPI.csproj` adds the `PostSharp` NuGet package only when PostSharp is enabled:

```xml
<EnablePostSharp Condition="'$(EnablePostSharp)' == ''">false</EnablePostSharp>
<DefineConstants Condition="'$(EnablePostSharp)' == 'true'">$(DefineConstants);POSTSHARP</DefineConstants>
...
<ItemGroup Condition="'$(EnablePostSharp)' == 'true'">
  <PackageReference Include="PostSharp" Version="2024.1.5" />
</ItemGroup>
```

### 3. Register the license key, then build with PostSharp on

Easiest: install the PostSharp tool once and register your key:

```bash
dotnet tool install -g PostSharp.Cli
postsharp license register <YOUR-FREE-LICENSE-KEY>
```

(Alternatively put the key in `AOPAPI.csproj` as `<PostSharpLicense>YOUR-KEY</PostSharpLicense>`.)

Then build / run with the flag that turns the aspect on:

```bash
dotnet build  -p:EnablePostSharp=true
dotnet run    --project AOPAPI -p:EnablePostSharp=true
```

Now `UserService`'s methods are woven at build time: you'll see `Entry / Parameters / Success /
Exit / Value` lines (and exception handling) in the log **without** any decorator or proxy at
run time. Set `"Aop:Strategy": "Direct"` when testing PostSharp so the run-time wrappers don't
also fire — the PostSharp weaving alone provides the logging.

> If your PostSharp version doesn't yet list .NET 10 as supported, pin a version that does, or
> use the maintained successor **Metalama** (also free) — the aspect concept is the same.

---

## Project layout

```
AOP_CORE/
├─ AOP_CORE.sln
├─ nuget.config                 # restore only from nuget.org
├─ README.md
└─ AOPAPI/
   ├─ Program.cs                # host + pipeline (replaces Global.asax/WebApiConfig)
   ├─ appsettings.json          # Aop:Strategy switch
   ├─ log4net.config
   ├─ Controllers/              # ControllerBase Web API controllers
   ├─ BLL/                      # IUserService/UserService, ICourseService/CourseService
   ├─ DAL/                      # in-memory Context + repositories + entities
   ├─ Models/                   # request DTOs
   ├─ Validators/               # IValidator<T> + AssignCourseInputValidator
   ├─ Infrastructure/           # AopStrategy + AddAopServices (replaces UnityConfig)
   └─ Aspects/
      ├─ BaseDecorators/        # UserServiceBaseDecorator
      ├─ Interception/          # shared ReturnTypes helper
      ├─ Logging/
      │  ├─ Utility/            # ILogger + log4net Logger
      │  ├─ Decorator/          # UserServiceLoggingDecorator
      │  ├─ Interceptor/        # LoggingInterceptor (Castle IInterceptor)
      │  └─ PostSharp/          # LoggingAspect (#if POSTSHARP)
      └─ Validation/
         ├─ Utility/            # IValidationService + ValidationService
         ├─ Decorator/          # UserServiceValidationDecorator
         └─ Interceptor/        # ValidationInterceptor (Castle IInterceptor)
```
