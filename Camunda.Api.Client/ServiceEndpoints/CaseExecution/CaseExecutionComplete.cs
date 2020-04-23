using System.Collections.Generic;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.CaseExecution
{
    public class CaseExecutionComplete
    {
        public Dictionary<string, CaseExecutionVariableValue> Variables = new Dictionary<string, CaseExecutionVariableValue>();

        public List<CaseExecutionComplete> Deletions = new List<CaseExecutionComplete>();
    }
}