using Newtonsoft.Json.Serialization;

namespace Camunda.Api.Client.Infrastructure
{
    internal class StringEnumConverter : Newtonsoft.Json.Converters.StringEnumConverter
    {
        public StringEnumConverter()
        {
            NamingStrategy = new CamelCaseNamingStrategy();
            AllowIntegerValues = false; // integer values are not allowed because they dont't have API origin
        }
    }
}
