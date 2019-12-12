using System;
using System.Net.Http;
using System.Reflection;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using Camunda.Api.Client.Extensions;
using Camunda.Api.Client.Infrastructure;
using Camunda.Api.Client.ServiceEndpoints.CaseExecution;
using Camunda.Api.Client.ServiceEndpoints.DecisionDefinition;
using Camunda.Api.Client.ServiceEndpoints.Deployment;
using Camunda.Api.Client.ServiceEndpoints.Execution;
using Camunda.Api.Client.ServiceEndpoints.ExternalTask;
using Camunda.Api.Client.ServiceEndpoints.Group;
using Camunda.Api.Client.ServiceEndpoints.History;
using Camunda.Api.Client.ServiceEndpoints.Incident;
using Camunda.Api.Client.ServiceEndpoints.Job;
using Camunda.Api.Client.ServiceEndpoints.JobDefinition;
using Camunda.Api.Client.ServiceEndpoints.Message;
using Camunda.Api.Client.ServiceEndpoints.ProcessDefinition;
using Camunda.Api.Client.ServiceEndpoints.ProcessInstance;
using Camunda.Api.Client.ServiceEndpoints.CaseDefinition;
using Camunda.Api.Client.ServiceEndpoints.Signal;
using Camunda.Api.Client.ServiceEndpoints.Tenant;
using Camunda.Api.Client.ServiceEndpoints.User;
using Camunda.Api.Client.ServiceEndpoints.UserTask;
using Camunda.Api.Client.ServiceEndpoints.VariableInstance;

namespace Camunda.Api.Client
{
    public class CamundaClient
    {
        private Lazy<ICaseDefinitionRestService> _caseDefinitionRestService;
        private Lazy<ICaseExecutionRestService> _caseExecutionRestService;
        private Lazy<IDecisionDefinitionRestService> _decisionDefinitionRestService;
        private Lazy<IDeploymentRestService> _deploymentApi;
        private Lazy<IExecutionRestService> _executionApi;
        private Lazy<IExternalTaskRestService> _externalTaskApi;
        private Lazy<IGroupRestService> _groupApi;
        private Lazy<IIncidentRestService> _incidentApi;
        private Lazy<IJobDefinitionRestService> _jobDefinitionApi;
        private Lazy<IJobRestService> _jobApi;
        private Lazy<IMessageRestService> _messageApi;
        private Lazy<IProcessDefinitionRestService> _processDefinitionApi;
        private Lazy<IProcessInstanceRestService> _processInstanceApi;
        private Lazy<ISignalRestService> _signalApi;
        private Lazy<ITenantRestService> _tenantApi;
        private Lazy<IUserRestService> _userApi;
        private Lazy<IUserTaskRestService> _userTaskApi;
        private Lazy<IVariableInstanceRestService> _variableInstanceApi;

        private HistoricApi _historicApi;

        private string _hostUrl;
        private HttpClient _httpClient;

        private RefitSettings _refitSettings;
        private static JsonSerializerSettings _jsonSerializerSettings;
        private HttpMessageHandler _httpMessageHandler;
        internal static JsonSerializerSettings JsonSerializerSettings => _jsonSerializerSettings;

        static CamundaClient()
        {
            _jsonSerializerSettings = _jsonSerializerSettings ?? new JsonSerializerSettings
            {
                ContractResolver = new CustomCamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore, // do not send empty fields
            };

            _jsonSerializerSettings.Converters.Add(new StringEnumConverter());
            _jsonSerializerSettings.Converters.Add(new CustomIsoDateTimeConverter());
        }

        private void Initialize()
        {
            _httpMessageHandler = _httpMessageHandler ?? new ErrorMessageHandler();

            _refitSettings = _refitSettings ?? new RefitSettings
            {
                JsonSerializerSettings = _jsonSerializerSettings,
                UrlParameterFormatter = new CustomUrlParameterFormatter(),
                HttpMessageHandlerFactory = () => _httpMessageHandler
            };
        }

        private CamundaClient(string hostUrl)
        {
            _hostUrl = hostUrl;
            Initialize();
            CreateServices();
        }

        private CamundaClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            Initialize();
            CreateServices();
        }

        private CamundaClient(string hostUrl, HttpMessageHandler httpMessageHandler)
        {
            _hostUrl = hostUrl;
            _httpMessageHandler = httpMessageHandler;
            Initialize();
            CreateServices();
        }

        private void CreateServices()
        {
            _caseDefinitionRestService = CreateService<ICaseDefinitionRestService>();
            _caseExecutionRestService = CreateService<ICaseExecutionRestService>();
            _decisionDefinitionRestService = CreateService<IDecisionDefinitionRestService>();
            _deploymentApi = CreateService<IDeploymentRestService>();
            _executionApi = CreateService<IExecutionRestService>();
            _externalTaskApi = CreateService<IExternalTaskRestService>();
            _groupApi = CreateService<IGroupRestService>();
            _incidentApi = CreateService<IIncidentRestService>();
            _jobApi = CreateService<IJobRestService>();
            _jobDefinitionApi = CreateService<IJobDefinitionRestService>();
            _messageApi = CreateService<IMessageRestService>();
            _processDefinitionApi = CreateService<IProcessDefinitionRestService>();
            _processInstanceApi = CreateService<IProcessInstanceRestService>();
            _signalApi = CreateService<ISignalRestService>();
            _tenantApi = CreateService<ITenantRestService>();
            _userApi = CreateService<IUserRestService>();
            _userTaskApi = CreateService<IUserTaskRestService>();
            _variableInstanceApi = CreateService<IVariableInstanceRestService>();

            _historicApi = new HistoricApi()
            {
                ActivityInstanceApi = CreateService<IHistoricActivityInstanceRestService>(),
                CaseActivityInstanceApi = CreateService<IHistoricCaseActivityInstanceRestService>(),
                CaseDefinitionApi = CreateService<IHistoricCaseDefinitionRestService>(),
                CaseInstanceApi = CreateService<IHistoricCaseInstanceRestService>(),
                DecisionInstanceApi = CreateService<IHistoricDecisionInstanceRestService>(),
                DetailApi = CreateService<IHistoricDetailRestService>(),
                IncidentApi = CreateService<IHistoricIncidentRestService>(),
                JobLogApi = CreateService<IHistoricJobLogRestService>(),
                ProcessInstanceApi = CreateService<IHistoricProcessInstanceRestService>(),
                VariableInstanceApi = CreateService<IHistoricVariableInstanceRestService>(),
            };
        }

        private Lazy<I> CreateService<I>()
        {
            if (_httpClient != null)
                return new Lazy<I>(() => RestService.For<I>(_httpClient, _refitSettings));
            else
                return new Lazy<I>(() => RestService.For<I>(_hostUrl, _refitSettings));
        }

        public static CamundaClient Create(string hostUrl)
        {
            return new CamundaClient(hostUrl);
        }

        public static CamundaClient Create(string hostUrl, HttpMessageHandler httpMessageHandler)
        {
            return new CamundaClient(hostUrl, httpMessageHandler);
        }

        public static CamundaClient Create(HttpClient httpClient)
        {
            return new CamundaClient(httpClient);
        }

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/case-definition/"/>
        public CaseDefinitionService CaseDefinitions => new CaseDefinitionService(_caseDefinitionRestService.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/case-execution/"/>
        public CaseExecutionService CaseExecutions => new CaseExecutionService(_caseExecutionRestService.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/decision-definition/"/>
        public DecisionDefinitionService DecisionDefinitions => new DecisionDefinitionService(_decisionDefinitionRestService.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/deployment/"/>
        public DeploymentService Deployments => new DeploymentService(_deploymentApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/execution/"/>
        public ExecutionService Executions => new ExecutionService(_executionApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/external-task/"/>
        public ExternalTaskService ExternalTasks => new ExternalTaskService(_externalTaskApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/group/"/>
        public GroupService Group => new GroupService(_groupApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/history/"/>
        public HistoryService History => new HistoryService(_historicApi);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/incident/"/>
        public IncidentService Incidents => new IncidentService(_incidentApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/job-definition/"/>
        public JobDefinitionService JobDefinitions => new JobDefinitionService(_jobDefinitionApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/job/"/>
        public JobService Jobs => new JobService(_jobApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/message/"/>
        public MessageService Messages => new MessageService(_messageApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/process-definition/"/>
        public ProcessDefinitionService ProcessDefinitions => new ProcessDefinitionService(_processDefinitionApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/process-instance/"/>
        public ProcessInstanceService ProcessInstances => new ProcessInstanceService(_processInstanceApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/signal/"/>
        public SignalService Signals => new SignalService(_signalApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/task/"/>
        public TenantService Tenants => new TenantService(_tenantApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/tenant/"/>
        public UserService Users => new UserService(_userApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/user/"/>
        public UserTaskService UserTasks => new UserTaskService(_userTaskApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.9/reference/rest/variable-instance/"/>
        public VariableInstanceService VariableInstances => new VariableInstanceService(_variableInstanceApi.Value);
    }
}
