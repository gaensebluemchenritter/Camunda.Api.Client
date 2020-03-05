#region Usings

using System.Net.Http;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.DecisionRequirementsDefinition
{
    public class DecisionRequirementsDefinitionResourceById : DecisionRequirementsDefinitionResource
    {
        private IDecisionRequirementsDefinitionRestService _api;
        private string _id;

        internal DecisionRequirementsDefinitionResourceById(IDecisionRequirementsDefinitionRestService api, string id)
        {
            _api = api;
            _id = id;
        }

        public override Task<DecisionRequirementsDefinitionInfo> Get() => _api.GetById(_id);

        public override Task<DecisionRequirementsDefinitionDiagram> GetXml() => _api.GetXmlById(_id);

        public override Task<HttpResponseMessage> GetDiagram() => _api.GetDiagramById(_id);
    }
}
