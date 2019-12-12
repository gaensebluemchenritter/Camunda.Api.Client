using System.Collections.Generic;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Execution
{
    public class ExecutionTrigger
    {
        public Dictionary<string, VariableValue> Variables = new Dictionary<string, VariableValue>();
    }
}
