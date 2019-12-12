using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// This exception is used for any kind of errors that occur due to malformed parameters in a Http query.
    /// </summary>
    public class InvalidRequestException : RestException
    {
        public InvalidRequestException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }
}
