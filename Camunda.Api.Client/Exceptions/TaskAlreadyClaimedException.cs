using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// This exception is thrown when you try to claim a task that is already claimed by someone else.
    /// </summary>
    public class TaskAlreadyClaimedException : ProcessEngineException
    {
        public TaskAlreadyClaimedException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
