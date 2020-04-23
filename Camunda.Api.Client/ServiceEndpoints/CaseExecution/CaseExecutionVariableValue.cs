#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.CaseExecution
{
    public class CaseExecutionVariableValue : VariableValue
    {
        /// <summary>
        /// Indicates whether the variable must be created and/or update locally or not.
        /// If set to true, the creation or update happens locally and will not be propagated upwards in the execution hierarchy.
        /// </summary>
        public bool? Local { get; set; }
    }
}
