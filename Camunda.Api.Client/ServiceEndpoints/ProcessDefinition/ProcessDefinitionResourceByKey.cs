using Camunda.Api.Client.Extensions;
using Camunda.Api.Client.ServiceEndpoints.ProcessInstance;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.ProcessDefinition
{
    public class ProcessDefinitionResourceByKey : ProcessDefinitionResource
    {
        private IProcessDefinitionRestService _api;
        private string _processDefinitionKey;

        internal ProcessDefinitionResourceByKey(IProcessDefinitionRestService api, string processDefinitionKey)
        {
            _api = api;
            _processDefinitionKey = processDefinitionKey;
        }

        public override Task<ProcessDefinitionInfo> Get() => _api.GetByKey(_processDefinitionKey);

        public override Task<ProcessDefinitionDiagram> GetXml() => _api.GetXmlByKey(_processDefinitionKey);

        public override async Task<HttpContent> GetDiagram() => (await _api.GetDiagramByKey(_processDefinitionKey)).Content;

        public override Task<ProcessInstanceWithVariables> StartProcessInstance(StartProcessInstance parameters) => _api.StartProcessInstanceByKey(_processDefinitionKey, parameters);

        public override Task<ProcessInstanceInfo> SubmitForm(SubmitStartForm parameters) => _api.SubmitStartFormByKey(_processDefinitionKey, parameters);

        protected override Task<List<StatisticsResult>> GetActivityStatistics(bool includeFailedJobs, bool? includeIncidents, string includeIncidentsForType) =>
            _api.GetActivityStatisticsByKey(_processDefinitionKey, includeFailedJobs, includeIncidents, includeIncidentsForType);

        public override Task<FormInfo> GetStartForm() => _api.GetStartFormByKey(_processDefinitionKey);

        public override Task<string> GetRenderedForm() => _api.GetRenderedFormByKey(_processDefinitionKey);

        public override Task UpdateSuspensionState(ProcessDefinitionSuspensionState state) => _api.UpdateSuspensionStateByKey(_processDefinitionKey, state);

        public override Task<Dictionary<string, VariableValue>> GetFormVariables(params string[] variableNames) => _api.GetFormVariablesByKey(_processDefinitionKey, variableNames.Join());

        public override Task<Dictionary<string, VariableValue>> GetFormVariables(string[] variableNames, bool deserializeValues = true) => _api.GetFormVariablesByKey(_processDefinitionKey, variableNames.Join(), deserializeValues);

        public override string ToString() => _processDefinitionKey;
    }
}
