using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.UserTask
{
    public interface IUserTaskService
    {
        TaskResource this[string taskId] { get; }

        /// <summary>
        /// Retrieves the number of tasks for each candidate group.
        /// </summary>
        Task<List<TaskCountByCandidateGroupResult>> GetTaskCountByCandidateGroup();

        QueryResource<TaskQuery, UserTaskInfo> Query(TaskQuery query = null);
        Task Create(UserTask task);
    }
}