﻿using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Execution
{
    public class ExecutionService : IExecutionService
    {
        private IExecutionRestService _api;

        internal ExecutionService(IExecutionRestService api)
        {
            _api = api;
        }

        public ExecutionResource this[string executionId] => new ExecutionResource(_api, executionId);

        public QueryResource<ExecutionQuery, ExecutionInfo> Query(ExecutionQuery query = null) =>
            new QueryResource<ExecutionQuery, ExecutionInfo>(
                query,
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));
    }
}
