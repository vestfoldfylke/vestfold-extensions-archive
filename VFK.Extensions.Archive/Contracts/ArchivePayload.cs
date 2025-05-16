using System.Diagnostics.CodeAnalysis;

namespace VFK.Extensions.Archive.Contracts;

// NOTE: P360 SIF requires service and method to be camelCase
//       and parameter can be a mix of PascalCase and camelCase,
//       hence the inconsistent naming
[SuppressMessage("Style", "IDE1006:Naming Styles")]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class ArchivePayload
{
    public required string service { get; init; }
    public required string method { get; init; }
    public object? parameter { get; init; }
}