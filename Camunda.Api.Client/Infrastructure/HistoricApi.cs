using System;
using Camunda.Api.Client.ServiceEndpoints.History;
using Camunda.Api.Client.ServiceEndpoints.History.HistoricActivityInstance;
using Camunda.Api.Client.ServiceEndpoints.History.HistoricCaseActivityInstance;
using Camunda.Api.Client.ServiceEndpoints.History.HistoricCaseDefinition;
using Camunda.Api.Client.ServiceEndpoints.History.HistoricCaseInstance;
using Camunda.Api.Client.ServiceEndpoints.History.HistoricDecisionInstance;
using Camunda.Api.Client.ServiceEndpoints.History.HistoricDetail;
using Camunda.Api.Client.ServiceEndpoints.History.HistoricIncident;
using Camunda.Api.Client.ServiceEndpoints.History.HistoricJobLog;
using Camunda.Api.Client.ServiceEndpoints.History.HistoricProcessInstance;
using Camunda.Api.Client.ServiceEndpoints.History.HistoricVariableInstance;

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
