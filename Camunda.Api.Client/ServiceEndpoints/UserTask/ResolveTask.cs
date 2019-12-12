using System.Collections.Generic;
using Camunda.Api.Client.Extensions;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.UserTask
{
    public class ResolveTask
    {
        /// <summary>
        /// Object containing variable key-value pairs.
        /// </summary>
        public Dictionary<string, VariableValue> Variables = new Dictionary<string, VariableValue>();

        public ResolveTask SetVariable(string name, object value)
        {
            Variables = (Variables ?? new Dictionary<string, VariableValue>()).Set(name, value);
            return this;
        }
    }
}