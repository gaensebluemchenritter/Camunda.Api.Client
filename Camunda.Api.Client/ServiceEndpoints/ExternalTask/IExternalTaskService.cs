using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.ExternalTask
{
    public interface IExternalTaskService
    {
        QueryResource<ExternalTaskQuery, ExternalTaskInfo> Query(ExternalTaskQuery query = null);

        /// <param name="externalTaskId">The id of the external task to be retrieved.</param>
        ExternalTaskResource this[string externalTaskId] { get; }

        /// <summary>
        /// Fetches and locks a specific number of external tasks for execution by a worker. Query can be restricted to specific task topics and for each task topic an individual lock time can be provided.
        /// </summary>
        Task<List<LockedExternalTask>> FetchAndLock(FetchExternalTasks fetching);
    }
}
