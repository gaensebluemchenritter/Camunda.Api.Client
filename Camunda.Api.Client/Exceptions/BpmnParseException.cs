using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    /// <summary>
    /// Exception during the parsing of an BPMN model.
    /// </summary>
    public class BpmnParseException : ProcessEngineException
    {
        public BpmnParseException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }
}
