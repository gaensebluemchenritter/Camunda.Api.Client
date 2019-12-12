using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Represents any of the exception conditions that can arise during expression evaluation.
    /// </summary>
    public class ELException : ProcessEngineException
    {
        public ELException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
