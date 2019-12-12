using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Represents an exception in activiti cdi.
    /// </summary>
    public class ProcessEngineCdiException : ProcessEngineException
    {
        public ProcessEngineCdiException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
