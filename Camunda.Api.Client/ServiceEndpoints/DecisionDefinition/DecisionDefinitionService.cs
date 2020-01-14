using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.DecisionDefinition
{
    public class DecisionDefinitionService : IDecisionDefinitionService
    {
        private IDecisionDefinitionRestService _api;

        internal DecisionDefinitionService(IDecisionDefinitionRestService api)
        {
            _api = api;
        }

        public DecisionDefinitionResource this[string decisionDefinitionId] => new DecisionDefinitionResourceById(_api, decisionDefinitionId);

        public DecisionDefinitionResource ByKey(string decisionDefinitionKey) => new DecisionDefinitionResourceByKey(_api, decisionDefinitionKey);

        public DecisionDefinitionResource ByKey(string decisionDefinitionKey, string tenantId) => new DecisionDefinitionResourceByKeyAndTenantId(_api, decisionDefinitionKey, tenantId);

        public QueryResource<DecisionDefinitionQuery, DecisionDefinitionInfo> Query(DecisionDefinitionQuery query = null) =>
            new QueryResource<DecisionDefinitionQuery, DecisionDefinitionInfo>(_api, query);
    }
}