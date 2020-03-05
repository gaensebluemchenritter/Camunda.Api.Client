using Camunda.Api.Client.ServiceEndpoints.Authorization;
using Camunda.Api.Client.ServiceEndpoints.Batch;
using Camunda.Api.Client.ServiceEndpoints.CaseDefinition;
using Camunda.Api.Client.ServiceEndpoints.CaseExecution;
using Camunda.Api.Client.ServiceEndpoints.DecisionDefinition;
using Camunda.Api.Client.ServiceEndpoints.DecisionRequirementsDefinition;
using Camunda.Api.Client.ServiceEndpoints.Deployment;
using Camunda.Api.Client.ServiceEndpoints.Execution;
using Camunda.Api.Client.ServiceEndpoints.ExternalTask;
using Camunda.Api.Client.ServiceEndpoints.Group;
using Camunda.Api.Client.ServiceEndpoints.History;
using Camunda.Api.Client.ServiceEndpoints.Identity;
using Camunda.Api.Client.ServiceEndpoints.Incident;
using Camunda.Api.Client.ServiceEndpoints.Job;
using Camunda.Api.Client.ServiceEndpoints.JobDefinition;
using Camunda.Api.Client.ServiceEndpoints.Message;
using Camunda.Api.Client.ServiceEndpoints.ProcessDefinition;
using Camunda.Api.Client.ServiceEndpoints.ProcessInstance;
using Camunda.Api.Client.ServiceEndpoints.Signal;
using Camunda.Api.Client.ServiceEndpoints.Tenant;
using Camunda.Api.Client.ServiceEndpoints.User;
using Camunda.Api.Client.ServiceEndpoints.UserTask;
using Camunda.Api.Client.ServiceEndpoints.VariableInstance;

namespace Camunda.Api.Client
{
    public interface ICamundaClient
    {
        /// <see href="https://docs.camunda.org/manual/7.12/reference/rest/authorization/"/>
        IAuthorizationService Authorization { get; }

        /// <see href="https://docs.camunda.org/manual/7.13/reference/rest/batch/"/>
        IBatchService Batch { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/case-definition/"/>
        ICaseDefinitionService CaseDefinitions { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/case-execution/"/>
        ICaseExecutionService CaseExecutions { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/decision-definition/"/>
        IDecisionDefinitionService DecisionDefinitions { get; }

        /// <see href="https://docs.camunda.org/manual/7.13/reference/rest/decision-requirements-definition/"/>
        IDecisionRequirementsDefinitionService DecisionRequirementsDefinitions { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/deployment/"/>
        IDeploymentService Deployments { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/execution/"/>
        IExecutionService Executions { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/external-task/"/>
        IExternalTaskService ExternalTasks { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/group/"/>
        IGroupService Group { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/history/"/>
        IHistoryService History { get; }

        IIdentityService Identity { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/incident/"/>
        IIncidentService Incidents { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/job-definition/"/>
        IJobDefinitionService JobDefinitions { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/job/"/>
        IJobService Jobs { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/message/"/>
        IMessageService Messages { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/process-definition/"/>
        IProcessDefinitionService ProcessDefinitions { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/process-instance/"/>
        IProcessInstanceService ProcessInstances { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/signal/"/>
        ISignalService Signals { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/task/"/>
        ITenantService Tenants { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/tenant/"/>
        IUserService Users { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/user/"/>
        IUserTaskService UserTasks { get; }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/variable-instance/"/>
        IVariableInstanceService VariableInstances { get; }
    }
}