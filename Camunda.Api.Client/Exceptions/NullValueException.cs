using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    public class NullValueException : ProcessEngineException
    {
        public NullValueException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
