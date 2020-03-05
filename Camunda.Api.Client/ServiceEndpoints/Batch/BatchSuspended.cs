#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.Batch
{
    public class BatchSuspended
    {
        /// <summary>
        /// indicates whether to activate or suspend the batch. When the value is set to true, the batch will be suspended and when the value is set to false, the batch will be activated.
        /// </summary>
        public bool Suspended;
    }
}
