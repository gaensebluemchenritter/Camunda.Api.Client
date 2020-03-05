﻿
using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.ExternalTask
{

    public class ExternalTaskService : IExternalTaskService
    {
        private IExternalTaskRestService _api;

        internal ExternalTaskService(IExternalTaskRestService api) { _api = api; }

        public QueryResource<ExternalTaskQuery, ExternalTaskInfo> Query(ExternalTaskQuery query = null) =>
            new QueryResource<ExternalTaskQuery, ExternalTaskInfo>(
                query,
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));

        /// <param name="externalTaskId">The id of the external task to be retrieved.</param>
        public ExternalTaskResource this[string externalTaskId] => new ExternalTaskResource(_api, externalTaskId);
        
        /// <summary>
        /// Fetches and locks a specific number of external tasks for execution by a worker. Query can be restricted to specific task topics and for each task topic an individual lock time can be provided.
        /// </summary>
        public Task<List<LockedExternalTask>> FetchAndLock(FetchExternalTasks fetching) => _api.FetchAndLock(fetching);
    }
}
