using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Exception that is thrown when an optimistic locking occurs in the datastore  caused by concurrent access of the same data entry.
    /// </summary>
    public class OptimisticLockingException : ProcessEngineException
    {
        public OptimisticLockingException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
