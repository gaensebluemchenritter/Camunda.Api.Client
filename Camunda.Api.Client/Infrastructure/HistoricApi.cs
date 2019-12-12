using System;
using Camunda.Api.Client.ServiceEndpoints.History;

namespace Camunda.Api.Client.Infrastructure
{
    internal class HistoricApi
    {
        public Lazy<IHistoricActivityInstanceRestService> ActivityInstanceApi;
        public Lazy<IHistoricCaseActivityInstanceRestService> CaseActivityInstanceApi;
        public Lazy<IHistoricCaseDefinitionRestService> CaseDefinitionApi;
        public Lazy<IHistoricCaseInstanceRestService> CaseInstanceApi;
        public Lazy<IHistoricDecisionInstanceRestService> DecisionInstanceApi;
        public Lazy<IHistoricDetailRestService> DetailApi;
        public Lazy<IHistoricIncidentRestService> IncidentApi;
        public Lazy<IHistoricJobLogRestService> JobLogApi;
        public Lazy<IHistoricProcessInstanceRestService> ProcessInstanceApi;
        public Lazy<IHistoricVariableInstanceRestService> VariableInstanceApi;
    }
}
