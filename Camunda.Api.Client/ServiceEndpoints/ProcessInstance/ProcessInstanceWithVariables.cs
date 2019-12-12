using System.Collections.Generic;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.ProcessInstance
{
    public class ProcessInstanceWithVariables : ProcessInstanceInfo
    {
        /// <summary>
        /// Object containing a property for each of the latest variables.
        /// </summary>
        public Dictionary<string, VariableValue> Variables;
    }
}
