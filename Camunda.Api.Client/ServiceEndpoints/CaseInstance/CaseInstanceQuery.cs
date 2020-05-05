#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.CaseInstance
{
    public class CaseInstanceQuery
    {
        [JsonProperty("caseInstanceId")]
        public string CaseInstanceId;

        [JsonProperty("businessKey")]
        public string BusinessKey;

        [JsonProperty("caseDefinitionId")]
        public string CaseDefinitionId;

        [JsonProperty("caseDefinitionKey")]
        public string CaseDefinitionKey;

        [JsonProperty("deploymentId")]
        public string DeploymentId;

        [JsonProperty("superProcessInstance")]
        public string SuperProcessInstance;

        [JsonProperty("subProcessInstance")]
        public string SubProcessInstance;

        [JsonProperty("superCaseInstance")]
        public string SuperCaseInstance;

        [JsonProperty("subCaseInstance")]
        public string SubCaseInstance;

        [JsonProperty("active")]
        public bool? Active;

        [JsonProperty("completed")]
        public bool? Completed;

        [JsonProperty("tenantIdIn")]
        public List<string> TenantIdIn;

        [JsonProperty("withoutTenantId")]
        public bool? WithoutTenantId;

        [JsonProperty("variables")]
        public List<CaseInstanceQueryVariable> Variables;

        [JsonProperty("variableNamesIgnoreCase")]
        public bool VariableNamesIgnoreCase;

        [JsonProperty("variableValuesIgnoreCase")]
        public bool VariableValuesIgnoreCase;

        [JsonProperty("sorting")]
        public List<CaseInstanceSorting> Sorting;
    }
}
