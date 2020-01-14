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

namespace Camunda.Api.Client.ServiceEndpoints.History
{
    public interface IHistoryService
    {
        /// <summary>
        /// Case Definition
        /// </summary>
        HistoricCaseDefinitionService CaseDefinitions { get; }

        /// <summary>
        /// Case Instance
        /// </summary>
        HistoricCaseInstanceService CaseInstances { get; }

        /// <summary>
        /// Case Activity Instance
        /// </summary>
        HistoricCaseActivityInstanceService CaseActivityInstances { get; }

        /// <summary>
        /// Decision Instance
        /// </summary>
        HistoricDecisionInstanceService DecisionInstances { get; }

        /// <summary>
        /// Process Instance
        /// </summary>
        HistoricProcessInstanceService ProcessInstances { get; }

        /// <summary>
        /// Activity Instance
        /// </summary>
        HistoricActivityInstanceService ActivityInstances { get; }

        /// <summary>
        /// Job Log
        /// </summary>
        HistoricJobLogService JobLogs { get; }

        /// <summary>
        /// Incident
        /// </summary>
        HistoricIncidentService Incidents { get; }

        /// <summary>
        /// Variable Instance
        /// </summary>
        HistoricVariableInstanceService VariableInstances { get; }

        /// <summary>
        /// Detail
        /// </summary>
        HistoricDetailService Detail { get; }
    }
}