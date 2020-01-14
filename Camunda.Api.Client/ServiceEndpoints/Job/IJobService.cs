using System.Threading.Tasks;
using Camunda.Api.Client.Resources;
using Camunda.Api.Client.ServiceEndpoints.Batch;

namespace Camunda.Api.Client.ServiceEndpoints.Job
{
    public interface IJobService
    {
        QueryResource<JobQuery, JobInfo> Query(JobQuery query = null);

        /// <param name="jobId">The id of the job to be retrieved.</param>
        JobResource this[string jobId] { get; }

        /// <summary>
        /// Activate or suspend jobs with the given job definition id, process definition id, process definition key or process instance id.
        /// </summary>
        Task UpdateSuspensionState(JobSuspensionState state);

        /// <summary>
        /// Create a batch to set retries of jobs asynchronously.
        /// </summary>
        Task<BatchInfo> SetJobRetries(JobRetries retries);
    }
}