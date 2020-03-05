#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.Batch
{
    public class BatchDelete
    {
        /// <summary>
        /// true, if the historic batch and historic job logs for this batch should also be deleted.
        /// </summary>
        public bool? Cascade;
    }
}
