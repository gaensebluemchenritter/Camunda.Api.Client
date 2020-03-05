﻿using System.Threading.Tasks;
using Camunda.Api.Client.Resources;
using Camunda.Api.Client.ServiceEndpoints.Batch;

namespace Camunda.Api.Client.ServiceEndpoints.Job
{
    public class JobService : IJobService
    {
        private IJobRestService _api;

        internal JobService(IJobRestService api)
        {
            _api = api;
        }

        public QueryResource<JobQuery, JobInfo> Query(JobQuery query = null) =>
            new QueryResource<JobQuery, JobInfo>(query, (q, f, m) => _api.GetList(q, f, m), q => _api.GetListCount(q));

        /// <param name="jobId">The id of the job to be retrieved.</param>
        public JobResource this[string jobId] => new JobResource(_api, jobId);

        /// <summary>
        /// Activate or suspend jobs with the given job definition id, process definition id, process definition key or process instance id.
        /// </summary>
        public Task UpdateSuspensionState(JobSuspensionState state) => _api.UpdateSuspensionState(state);

        /// <summary>
        /// Create a batch to set retries of jobs asynchronously.
        /// </summary>
        public Task<BatchInfo> SetJobRetries(JobRetries retries) => _api.SetJobRetriesAsync(retries);
    }
}
