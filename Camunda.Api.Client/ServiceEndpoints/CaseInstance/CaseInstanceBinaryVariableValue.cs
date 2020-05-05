#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;
using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.CaseInstance
{
    public class CaseInstanceBinaryVariableValue
    {
        [JsonProperty("data")]
        public string Data;

        [JsonProperty("valueType")]
        public BinaryVariableType ValueType;
    }
}
