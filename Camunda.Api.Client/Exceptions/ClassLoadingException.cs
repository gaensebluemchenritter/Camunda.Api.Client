using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Runtime exception indicating the requested class was not found or an error occurred while loading the class.
    /// </summary>
    public class ClassLoadingException : ProcessEngineException
    {
        [JsonProperty]
        internal string ClassName { get; private set; }

        public ClassLoadingException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
