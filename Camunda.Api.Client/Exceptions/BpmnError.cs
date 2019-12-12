using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Special exception that can be used to throw a BPMN Error from JavaDelegate and expressions.
    /// This should only be used for business faults, which shall be handled by a Boundary Error Event or Error Event Sub-Process modeled in the process definition.
    /// Technical errors should be represented by other exception types.
    /// </summary>
    public class BpmnError : ProcessEngineException
    {
        [JsonProperty]
        public string ErrorCode { get; private set; }
        [JsonProperty]
        public string ErrorMessage { get; private set; }

        public BpmnError(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
