using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    public class DeploymentResourceNotFoundException : ProcessEngineException
    {
        public DeploymentResourceNotFoundException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
