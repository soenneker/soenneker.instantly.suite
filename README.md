[![](https://img.shields.io/nuget/v/soenneker.instantly.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.instantly.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.instantly.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.instantly.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.instantly.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.instantly.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.instantly.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.instantly.suite/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Instantly.Suite

Install and register Instantly account, analytics, DFY, lead, Unibox, and email-verification operations together.

## Install

```bash
dotnet add package Soenneker.Instantly.Suite
```

This package references:

- `Soenneker.Instantly.Accounts`
- `Soenneker.Instantly.Analytics`
- `Soenneker.Instantly.Dfy`
- `Soenneker.Instantly.Leads`
- `Soenneker.Instantly.Unibox`
- `Soenneker.Instantly.Verification`

Use the individual packages instead when an application needs only part of that surface.

## Configure

```json
{
  "Instantly": {
    "ApiKey": "<API key>",
    "LogEnabled": false,
    "RequestResponseLogging": false
  }
}
```

`ApiKey` is required. `LogEnabled` controls operation-level logging in supported packages. `RequestResponseLogging` enables debug-level HTTP traffic logging and may expose sensitive headers or bodies, so enable it deliberately.

## Register

For scoped operation services over the shared Instantly client provider:

```csharp
using Soenneker.Instantly.Suite.Registrars;

services.AddInstantlySuiteAsScoped();
```

For application-lifetime operation services:

```csharp
services.AddInstantlySuiteSingleton();
```

These methods register all six packages listed above. Resolve their interfaces—for example `IInstantlyAccountsUtil`, `IInstantlyAnalyticsUtil`, or `IInstantlyLeadUtil`—and use each package's README for operation-specific behavior and safety notes.
