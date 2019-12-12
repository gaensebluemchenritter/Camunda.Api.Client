using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Unable to bootstrap server.
    /// </summary>
    public class ServerBootstrapException : RuntimeException
    {
        public ServerBootstrapException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }
}
