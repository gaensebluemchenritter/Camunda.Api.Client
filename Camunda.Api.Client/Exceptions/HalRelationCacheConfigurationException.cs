using System.Net.Http;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    public class HalRelationCacheConfigurationException : RuntimeException
    {
        public HalRelationCacheConfigurationException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }
}
