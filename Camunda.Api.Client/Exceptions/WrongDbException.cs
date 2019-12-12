using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Exception that is thrown when the Activiti engine discovers a mismatch between the database schema version and the engine version.
    /// </summary>
    public class WrongDbException : ProcessEngineException
    {
        public WrongDbException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
