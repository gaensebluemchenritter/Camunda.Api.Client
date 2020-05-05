#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.CaseInstance
{
    public class CaseInstanceDeleteVariable
    {
        [JsonProperty("name")]
        public string Name;
    }
}
