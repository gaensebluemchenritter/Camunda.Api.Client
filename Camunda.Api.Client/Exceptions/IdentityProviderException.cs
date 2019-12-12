using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Marks an exception triggered inside an identity provider implementation.
    /// </summary>
    public class IdentityProviderException : ProcessEngineException
    {
        public IdentityProviderException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
