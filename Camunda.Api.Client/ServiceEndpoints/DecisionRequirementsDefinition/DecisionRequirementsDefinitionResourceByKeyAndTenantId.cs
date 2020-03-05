#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.DecisionRequirementsDefinition
{
    public class DecisionRequirementsDefinitionResourceByKeyAndTenantId : DecisionRequirementsDefinitionResource
    {
        private IDecisionRequirementsDefinitionRestService _api;
        private string _key;
        private string _tenantId;

        internal DecisionRequirementsDefinitionResourceByKeyAndTenantId(IDecisionRequirementsDefinitionRestService api, string key, string tenantId)
        {
            _api = api;
            _key = key;
            _tenantId = tenantId;
        }

        public override Task<DecisionRequirementsDefinitionInfo> Get() => _api.GetByKeyAndTenantId(_key, _tenantId);

        public override Task<DecisionRequirementsDefinitionDiagram> GetXml() =>
            _api.GetXmlByKeyAndTenantId(_key, _tenantId);

        public override Task<HttpResponseMessage> GetDiagram() => _api.GetDiagramByKeyAndTenantId(_key, _tenantId);
    }
}
