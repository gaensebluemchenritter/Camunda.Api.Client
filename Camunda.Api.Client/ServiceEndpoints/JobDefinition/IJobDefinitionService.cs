using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.JobDefinition
{
    public interface IJobDefinitionService
    {
        QueryResource<JobDefinitionQuery, JobDefinitionInfo> Query(JobDefinitionQuery query = null);

        /// <param name="jobDefinitionId">The id of the job to be retrieved.</param>
        JobDefinitionResource this[string jobDefinitionId] { get; }

        /// <summary>
        /// Activate or suspend jobs with the given job definition id, process definition id, process definition key or process instance id.
        /// </summary>
        Task UpdateSuspensionState(JobDefinitionSuspensionState state);
    }
}