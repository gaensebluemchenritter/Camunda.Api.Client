using Newtonsoft.Json.Serialization;

namespace Camunda.Api.Client.Infrastructure
{
    internal class CustomCamelCasePropertyNamesContractResolver : CamelCasePropertyNamesContractResolver
    {
        // preserve exact dictionary key
        protected override string ResolveDictionaryKey(string dictionaryKey) => dictionaryKey;
    }
}
