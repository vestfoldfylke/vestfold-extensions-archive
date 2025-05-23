using Microsoft.Extensions.DependencyInjection;
using Vestfold.Extensions.Archive.Services;

namespace Vestfold.Extensions.Archive;

public static class ArchiveExtension
{
    public static IServiceCollection AddVestfoldArchive(this IServiceCollection services) =>
        services.AddSingleton<IArchiveService, ArchiveService>();
}