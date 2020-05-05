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
    public class CaseInstanceVariableValue : VariableValue
    {
        [JsonProperty("local")]
        public bool Local;
    }
}
