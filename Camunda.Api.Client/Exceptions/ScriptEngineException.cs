using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Exception resulting from a error during a script compilation.
    /// </summary>
    public class ScriptEngineException : ProcessEngineException
    {
        public ScriptEngineException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
