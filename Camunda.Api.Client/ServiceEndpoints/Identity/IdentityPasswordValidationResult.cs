using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Camunda.Api.Client.ServiceEndpoints.Identity
{
    public class IdentityPasswordValidationResult
    {
        [JsonProperty("rules")]
        public List<IdentityPasswordRule> Rules { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}
