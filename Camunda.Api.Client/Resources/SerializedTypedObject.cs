using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Resources
{
    internal class SerializedTypedObject
    {
        [JsonProperty("data")] public string Data;
    }
}
