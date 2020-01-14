using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.DecisionDefinition
{
    public interface IDecisionDefinitionService
    {
        DecisionDefinitionResource this[string decisionDefinitionId] { get; }
        DecisionDefinitionResource ByKey(string decisionDefinitionKey);
        DecisionDefinitionResource ByKey(string decisionDefinitionKey, string tenantId);
        QueryResource<DecisionDefinitionQuery, DecisionDefinitionInfo> Query(DecisionDefinitionQuery query = null);
    }
}