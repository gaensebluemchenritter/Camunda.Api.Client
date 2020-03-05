#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.DecisionRequirementsDefinition
{
    public class DecisionRequirementsDefinitionResourceByKey : DecisionRequirementsDefinitionResource
    {
        private IDecisionRequirementsDefinitionRestService _api;
        private string _key;

        internal DecisionRequirementsDefinitionResourceByKey(IDecisionRequirementsDefinitionRestService api, string key)
        {
            _api = api;
            _key = key;
        }

        public override Task<DecisionRequirementsDefinitionInfo> Get() => _api.GetByKey(_key);

        public override Task<DecisionRequirementsDefinitionDiagram> GetXml() => _api.GetXmlByKey(_key);

        public override Task<HttpResponseMessage> GetDiagram() => _api.GetDiagramByKey(_key);
    }
}
