using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// RuntimeException is the superclass of those exceptions that can be thrown during the normal operation of the Java Virtual Machine
    /// </summary>
    public class RuntimeException : ApiException
    {
        public RuntimeException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }
}
