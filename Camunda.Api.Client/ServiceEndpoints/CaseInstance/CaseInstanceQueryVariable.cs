#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;
using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.CaseInstance
{
    public class CaseInstanceQueryVariable
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("operator")]
        public ConditionOperator Operator;

        [JsonProperty("value")] 
        public object Value;
    }
}
