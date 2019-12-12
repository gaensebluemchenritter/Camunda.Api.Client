using Camunda.Api.Client.ServiceEndpoints.CaseInstance;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ServiceEndpoints.CaseDefinition
{
    public class CaseDefinitionResourceByKeyAndTenantId : CaseDefinitionResource
    {
        private ICaseDefinitionRestService _api;
        private string _caseDefinitionKey, _tenantId;

        internal CaseDefinitionResourceByKeyAndTenantId(ICaseDefinitionRestService api, string caseDefinitionKey, string tenantId)
        {
            _api = api;
            _caseDefinitionKey = caseDefinitionKey;
            _tenantId = tenantId;
        }

        public override Task<CaseDefinitionInfo> Get() => _api.GetByKeyAndTenantId(_caseDefinitionKey, _tenantId);

        public override Task<CaseDefinitionDiagram> GetXml() => _api.GetXmlByKeyAndTenantId(_caseDefinitionKey, _tenantId);

        public override async Task<HttpContent> GetDiagram() => (await _api.GetDiagramByKeyAndTenantId(_caseDefinitionKey, _tenantId)).Content;

        public override Task<CaseInstanceInfo> CreateCaseInstance(CreateCaseInstance parameters) => _api.CreateCaseInstanceByKeyAndTenantId(_caseDefinitionKey, _tenantId, parameters);

        public override string ToString() => _caseDefinitionKey;
    }
}