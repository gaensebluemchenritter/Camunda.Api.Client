using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Exception thrown by the process engine in case a user tries to interact with a resource in an unauthorized way.
    /// </summary>
    public class AuthorizationException : ApiException
    {
        [JsonProperty]
        public string UserId { get; private set; }
        [JsonProperty]
        public string PermissionName { get; private set; }
        [JsonProperty]
        public string ResourceName { get; private set; }
        [JsonProperty]
        public string ResourceId { get; private set; }

        public AuthorizationException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
