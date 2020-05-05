#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.CaseInstance
{
    public class ChangeCaseInstanceState
    {
        [JsonProperty("variables")]
        public Dictionary<string, CaseInstanceVariableValue> Variables;

        [JsonProperty("deletions")]
        public List<CaseInstanceDeleteVariable> Deletions;
    }
}
