using Microsoft.Extensions.DependencyInjection;
using VFK.Extensions.Archive.Services;

namespace VFK.Extensions.Archive;

public static class ArchiveExtension
{
    public static IServiceCollection AddVfkArchive(this IServiceCollection services) =>
        services.AddSingleton<IArchiveService, ArchiveService>();
}