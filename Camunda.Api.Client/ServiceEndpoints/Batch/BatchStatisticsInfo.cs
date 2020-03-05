#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.Batch
{
    public class BatchStatisticsInfo : BatchInfo
    {
        /// <summary>
        /// The number of remaining batch execution jobs. This does include failed batch execution jobs and batch execution jobs which still have to be created by the seed job.
        /// </summary>
        public int RemainingJobs;
        /// <summary>
        /// The number of completed batch execution jobs. This does include aborted/deleted batch execution jobs.
        /// </summary>
        public int CompletedJobs;
        /// <summary>
        /// The number of failed batch execution jobs. This does not include aborted or deleted batch execution jobs.
        /// </summary>
        public int FailedJobs;
    }
}
