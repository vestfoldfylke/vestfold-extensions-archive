using System.Text.Json.Nodes;
using VFK.Extensions.Archive.Contracts;

namespace VFK.Extensions.Archive.Services;

public interface IArchiveService
{
    Task<JsonNode?> Archive(ArchivePayload payload);
    Task<JsonNode?> ArchiveCustom(object payload, string route);
    Task<JsonNode> CreateCase(object parameter);
    Task<JsonNode> CreateDocument(object parameter);
    Task<JsonArray> GetCases(object parameter);
    Task<JsonArray> GetProjects(object parameter);
    Task<JsonNode> SignOff(object parameter);

    Task<JsonNode> SyncEnterprise(string organizationNr);

    Task<JsonNode> SyncPrivatePerson(object privatePerson);
}