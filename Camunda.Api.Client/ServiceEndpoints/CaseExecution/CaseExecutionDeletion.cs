#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.CaseExecution
{
    public class CaseExecutionDeletion
    {
        public string Name { get; set; }
        public bool Local { get; set; }
    }
}
