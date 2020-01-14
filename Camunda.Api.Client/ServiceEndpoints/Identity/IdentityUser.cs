using Newtonsoft.Json;

namespace Camunda.Api.Client.ServiceEndpoints.Identity
{
    public class IdentityUser
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("firstName")]
        public string FirstName;

        [JsonProperty("lastName")]
        public string LastName;

        [JsonProperty("displayName")]
        public string DisplayName;

        public override string ToString() => Id;
    }
}
