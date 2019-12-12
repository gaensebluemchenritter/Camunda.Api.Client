using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// This is exception is thrown when a specific case definition is not found.
    /// </summary>
    public class CaseException : ProcessEngineException
    {
        public CaseException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
