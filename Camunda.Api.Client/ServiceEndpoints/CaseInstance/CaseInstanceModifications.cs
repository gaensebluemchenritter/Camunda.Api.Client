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
    public class CaseInstanceModifications
    {
        [JsonProperty("modifications")]
        public Dictionary<string, VariableValue> Modifications;
         
        [JsonProperty("deletions")]
        public List<CaseInstanceDeleteVariable> Deletions;
    }
}
