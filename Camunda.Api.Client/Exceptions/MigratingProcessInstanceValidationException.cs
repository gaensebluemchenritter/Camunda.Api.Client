using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Thrown if at least one migration instruction cannot be applied to the activity instance it matches.
    /// </summary>
    public class MigratingProcessInstanceValidationException : ProcessEngineException
    {
        public MigratingProcessInstanceValidationException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
