#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.CaseExecution
{
    public class CaseExecutionDeserialize
    {
        /// <summary>
        /// Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true).
        /// </summary>
        public bool? DesirializeValues { get; set; }
    }
}
