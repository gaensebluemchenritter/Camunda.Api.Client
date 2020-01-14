﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.UserTask
{
    public class UserTaskService : IUserTaskService
    {
        private IUserTaskRestService _api;

        internal UserTaskService(IUserTaskRestService api)
        {
            _api = api;
        }

        public TaskResource this[string taskId] => new TaskResource(_api, taskId);

        /// <summary>
        /// Retrieves the number of tasks for each candidate group.
        /// </summary>
        public Task<List<TaskCountByCandidateGroupResult>> GetTaskCountByCandidateGroup() => _api.GetTaskCountByCandidateGroup();

        public QueryResource<TaskQuery, UserTaskInfo> Query(TaskQuery query = null)
            => new QueryResource<TaskQuery, UserTaskInfo>(_api, query);

        public Task Create(UserTask task) => _api.CreateTask(task);
    }
}
