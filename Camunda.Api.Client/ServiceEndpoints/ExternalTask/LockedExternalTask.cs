using System;
using System.Collections.Generic;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.ExternalTask
{
    public class LockedExternalTask : ExternalTaskInfo
    {
        /// <summary>
        /// Object containing a property for each of the requested variables.
        /// </summary>
        public Dictionary<string, VariableValue> Variables;
    }
}
