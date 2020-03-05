#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.DecisionRequirementsDefinition
{
    public class DecisionRequirementsDefinitionService : IDecisionRequirementsDefinitionService
    {
        private IDecisionRequirementsDefinitionRestService _api;

        internal DecisionRequirementsDefinitionService(IDecisionRequirementsDefinitionRestService api)
        {
            _api = api;
        }

        public DecisionRequirementsDefinitionResource this[string id] => new DecisionRequirementsDefinitionResourceById(_api, id);

        public DecisionRequirementsDefinitionResource ByKey(string key) => new DecisionRequirementsDefinitionResourceByKey(_api, key);

        public DecisionRequirementsDefinitionResource ByKey(string key, string tenantId) => new DecisionRequirementsDefinitionResourceByKeyAndTenantId(_api, key, tenantId);

        public QueryResource<DecisionRequirementsDefinitionQuery, DecisionRequirementsDefinitionInfo> Query(
            DecisionRequirementsDefinitionQuery query = null) =>
            new QueryResource<DecisionRequirementsDefinitionQuery, DecisionRequirementsDefinitionInfo>(query,
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));
    }
}
