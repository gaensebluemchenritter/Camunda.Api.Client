using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.DecisionRequirementsDefinition
{
    public interface IDecisionRequirementsDefinitionService
    {
        DecisionRequirementsDefinitionResource this[string id] { get; }
        DecisionRequirementsDefinitionResource ByKey(string key);
        DecisionRequirementsDefinitionResource ByKey(string key, string tenantId);

        QueryResource<DecisionRequirementsDefinitionQuery, DecisionRequirementsDefinitionInfo> Query(
            DecisionRequirementsDefinitionQuery query = null);
    }
}