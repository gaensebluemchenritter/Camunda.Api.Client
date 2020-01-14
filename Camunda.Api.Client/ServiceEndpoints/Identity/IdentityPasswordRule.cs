using System.Collections.Generic;
using Newtonsoft.Json;

namespace Camunda.Api.Client.ServiceEndpoints.Identity
{
    public class IdentityPasswordRule
    {
        /// <summary>
        /// A placeholder string that can be used to display an internationalized message to the user.
        /// </summary>
        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        /// <summary>
        /// A map of parameters that can be used to display a parameterized message to the user.
        /// </summary>
        [JsonProperty("parameters")]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// true if the password is compliant with this rule, otherwise false
        /// </summary>
        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}
