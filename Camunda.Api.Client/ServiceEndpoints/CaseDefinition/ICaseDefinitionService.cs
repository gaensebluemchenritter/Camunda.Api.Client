using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.CaseDefinition
{
    public interface ICaseDefinitionService
    {
        CaseDefinitionResource this[string caseDefinitionId] { get; }
        CaseDefinitionResource ByKey(string caseDefinitionKey);
        CaseDefinitionResource ByKey(string caseDefinitionKey, string tenantId);
        QueryResource<CaseDefinitionQuery, CaseDefinitionInfo> Query(CaseDefinitionQuery query = null);
    }
}