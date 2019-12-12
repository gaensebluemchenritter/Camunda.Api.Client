using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Runtime exception that is the superclass of all exceptions in the process engine.
    /// </summary>
    public class ProcessEngineException : RuntimeException
    {
        public ProcessEngineException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }
}
