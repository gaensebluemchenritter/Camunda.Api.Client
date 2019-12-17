using System.Collections.Generic;
using Camunda.Api.Client.Extensions;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.UserTask
{
    public class CompleteTask
    {
        /// <summary>
        /// Object containing variable key-value pairs.
        /// </summary>
        public Dictionary<string, VariableValue> Variables = new Dictionary<string, VariableValue>();

        /// <summary>
        /// if set to true, API will return variables in response. Default behaviour is "false"
        /// </summary>
        public bool? WithVariablesInReturn { get; set; } = null;

        public CompleteTask SetVariable(string name, object value)
        {
            Variables = (Variables ?? new Dictionary<string, VariableValue>()).Set(name, value);
            return this;
        }
    }
}
