using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// The JSONException is thrown by the JSON.org classes when things are amiss.
    /// </summary>
    public class JSONException : RuntimeException
    {
        public JSONException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }
}
