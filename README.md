![NuGet Version](https://img.shields.io/nuget/v/VFK.Extensions.Archive.svg)
![NuGet Downloads](https://img.shields.io/nuget/dt/VFK.Extensions.Archive.svg)

# VFK.Extensions.Archive

Contains builder extensions to extend a dotnet core application with archive functionality.

## Usage in an Azure Function / Azure Web App

Create a `local.settings.json` file:

```json
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet-isolated",
    "ARCHIVE_BASE_URL": "https://archive.url/",
    "ARCHIVE_SCOPE": "https://archive.url/.default"
  }
}
```

## Usage outside Azure

Create an `appsettings.json` file:

```json
{
  "ARCHIVE_BASE_URL": "https://archive.url/",
  "ARCHIVE_SCOPE": "https://archive.url/.default"
}
```

## Setting up for an Azure Function / Azure Web App

```csharp
var builder = FunctionsApplication.CreateBuilder(args);
builder.ConfigureFunctionsWebApplication();
builder.Services.AddVfkArchive();
builder.Build().Run();
```

## Setting up for a HostBuilder (Console app, ClassLibrary, etc.)

```csharp
public static async Task Main(string[] args)
{
    await Host.CreateDefaultBuilder(args)
        .ConfigureServices(services => services.AddVfkArchive())
        .Build()
        .RunAsync();

    await Serilog.Log.CloseAndFlushAsync();
}
```

## Setting up for a WebApplicationBuilder (WebAPI, Blazor, etc.)

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddVfkArchive();

var app = builder.Build();
```