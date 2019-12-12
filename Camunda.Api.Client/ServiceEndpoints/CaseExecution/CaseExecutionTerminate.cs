using System.Collections.Generic;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.CaseExecution
{
    public class CaseExecutionTerminate
    {
        public Dictionary<string, VariableValue> Variables = new Dictionary<string, VariableValue>();

        // TODO: deletions
    }
}