using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Camunda.Api.Client.ServiceEndpoints.Identity
{
    public class IdentityPassword
    {
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
