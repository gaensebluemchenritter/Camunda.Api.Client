using Newtonsoft.Json;

namespace Camunda.Api.Client.ServiceEndpoints.Identity
{
    public class IdentityGroup
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        public string ToString() => Id;
    }
}