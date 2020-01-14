using System.Threading.Tasks;
using Camunda.Api.Client.Resources;
using Camunda.Api.Client.ServiceEndpoints.Batch;

namespace Camunda.Api.Client.ServiceEndpoints.ProcessInstance
{
    public interface IProcessInstanceService
    {
        QueryResource<ProcessInstanceQuery, ProcessInstanceInfo> Query(ProcessInstanceQuery query = null);

        /// <param name="processInstanceId">The id of the process instance to be retrieved.</param>
        ProcessInstanceResource this[string processInstanceId] { get; }

        /// <summary>
        /// Activate or suspend process instances with the given process definition id or process definition key.
        /// </summary>
        Task UpdateSuspensionState(ProcessInstanceSuspensionState state);

        /// <summary>
        /// Deletes multiple process instances asynchronously (batch).
        /// </summary>
        Task<BatchInfo> Delete(DeleteProcessInstances deleteProcessInstances);

        /// <summary>
        /// Create a batch to set retries of jobs associated with given processes asynchronously.
        /// </summary>
        Task<BatchInfo> SetRetriesByProcess(JobRetriesByProcess setJobRetries);
    }
}