using System.Collections.Generic;
using Newtonsoft.Json;

namespace Camunda.Api.Client.ServiceEndpoints.Identity
{
    public class IdentityPasswordPolicy
    {
        [JsonProperty("rules")]
        public List<IdentityPasswordRule> Rules { get; set; }
    }
}
