using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// This exception is thrown when a specific decision definition is not found.
    /// </summary>
    public class DecisionException : ProcessEngineException
    {
        public DecisionException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
