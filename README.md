# SwelogDb

Entity Framework Core model for an existing Swelog SQL Server database. This library provides typed access to a business database schema covering customers, suppliers, orders, inventory, manufacturing, accounting and related reporting views.

The repository contains the model imported in September 2023. It does not identify a supported Swelog product/database version, so compare the mappings with the database you intend to use. Database contents, provisioning scripts, migrations and a runnable Swelog application are not included.

## Contents and requirements

| Component | Purpose |
|---|---|
| [SwelogDb](https://github.com/LTRData/SwelogDb/tree/main/SwelogDb) | Class library targeting `net6.0` and `net7.0`, with EF Core SQL Server and design packages at version `7.*`. |
| [SwedbContext](https://github.com/LTRData/SwelogDb/blob/main/SwelogDb/Entity/SwedbContext.cs) | EF Core context containing the `DbSet` properties and explicit table, view, column, key and relationship mappings. |
| [Entity classes](https://github.com/LTRData/SwelogDb/tree/main/SwelogDb/Entity) | More than 1,700 partial classes in the `SwelogDb.Entity` namespace, including `Customer`, `Item`, `Supplier` and reporting models. |

Consumers need a compatible .NET application, EF Core 7 dependencies, and access to an existing SQL Server database matching these mappings. Some mapped types are keyless, including reporting views; the model is not a complete implementation of Swelog's business workflows.

## Configure a consuming application

Reference `SwelogDb/SwelogDb.csproj` from your application, or use a package built from this repository. The package metadata specifies `LTRData.SwelogDb`, version `1.0.0`.

`SwedbContext.OnConfiguring` always calls:

```csharp
optionsBuilder.UseSqlServer("name=Swedb");
```

Supply the named connection string through the application's configuration, for example as `ConnectionStrings:Swedb` (or the environment variable `ConnectionStrings__Swedb`). Its value must be a SQL Server connection string for your installation.

In an ASP.NET Core application's `Program.cs`, register the context before building the application:

```csharp
using Microsoft.Extensions.DependencyInjection;
using SwelogDb.Entity;

// builder is the application's WebApplicationBuilder.
builder.Services.AddDbContext<SwedbContext>();
```

This lets EF Core resolve the connection name through the application's `IConfiguration`. Inject `SwedbContext` into a scoped service or request handler. For example, with an injected context named `db`:

```csharp
using System.Linq;
using Microsoft.EntityFrameworkCore;

var customers = await db.Customers
    .AsNoTracking()
    .OrderBy(customer => customer.CustomerId)
    .Select(customer => new { customer.CustomerId, customer.CustomerName })
    .Take(20)
    .ToListAsync();
```

A bare `new SwedbContext()` does not supply the configuration services needed to resolve the name. Passing a different connection string through `DbContextOptions` also does not bypass the unconditional `OnConfiguring` call. Use the named configuration above, or explicitly adapt/override that method when integrating another configuration approach.

## Build

From the repository root, using a .NET SDK capable of targeting .NET 7:

```sh
dotnet build SwelogDb/SwelogDb.csproj -c Debug -f net7.0
```

Debug builds avoid automatic package generation. Release builds are configured to generate the NuGet package, with `LocalNuGetPath` used as the package output path.

The entity classes and context are partial. When building from source, additional partial files can extend them, and `OnModelCreatingPartial(ModelBuilder)` provides a hook after the checked-in mappings.
