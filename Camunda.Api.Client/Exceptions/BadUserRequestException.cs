using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Exception resulting from a bad user request. A bad user request is an interaction where the user requests some non-existing state or attempts to perform an illegal action on some entity.
    /// </summary>
    public class BadUserRequestException : ProcessEngineException
    {
        public BadUserRequestException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
