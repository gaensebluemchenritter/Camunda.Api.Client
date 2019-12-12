using System.Collections.Generic;
using Camunda.Api.Client.Extensions;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.DecisionDefinition
{
    public class EvaluateDecision
    {
        /// <summary>
        /// Object containing the variables the decision is to be evaluated with. Each key corresponds to a variable name and each value to a variable value.
        /// </summary>
        public Dictionary<string, VariableValue> Variables = new Dictionary<string, VariableValue>();

        public EvaluateDecision SetVariable(string name, object value)
        {
            Variables = (Variables ?? new Dictionary<string, VariableValue>()).Set(name, value);
            return this;
        }
    }
}