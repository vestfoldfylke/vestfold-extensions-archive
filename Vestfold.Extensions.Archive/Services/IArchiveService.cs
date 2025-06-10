using System.Text.Json.Nodes;
using Vestfold.Extensions.Archive.Contracts;

namespace Vestfold.Extensions.Archive.Services;

public interface IArchiveService
{
    Task<JsonNode?> Archive(ArchivePayload payload);
    Task<JsonNode?> ArchiveCustom(object payload, string route);
    Task<JsonNode> CreateCase(object parameter);
    Task<JsonNode> CreateDocument(object parameter);
    Task<JsonArray> GetCases(object parameter);
    Task<JsonArray> GetDocuments(object parameter);
    (string, string) GetFileExtension(string input);
    Task<JsonArray> GetProjects(object parameter);
    Task<JsonNode> SignOff(object parameter);
    Task<JsonNode> SyncEnterprise(string organizationNr);
    Task<JsonNode> SyncPrivatePerson(object privatePerson);
    Task<JsonNode> UpdateCase(object parameter);
}