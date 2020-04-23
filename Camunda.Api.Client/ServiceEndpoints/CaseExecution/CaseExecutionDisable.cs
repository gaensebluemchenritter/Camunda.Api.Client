using System.Collections.Generic;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.CaseExecution
{
    public class CaseExecutionDisable
    {
        public Dictionary<string, CaseExecutionVariableValue> Variables = new Dictionary<string, CaseExecutionVariableValue>();

        public List<CaseExecutionDeletion> Deletions = new List<CaseExecutionDeletion>();
    }
}