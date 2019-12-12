﻿using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Execution
{
    public class ExecutionService
    {
        private IExecutionRestService _api;

        internal ExecutionService(IExecutionRestService api)
        {
            _api = api;
        }

        public ExecutionResource this[string executionId] => new ExecutionResource(_api, executionId);

        public QueryResource<ExecutionQuery, ExecutionInfo> Query(ExecutionQuery query = null)
            => new QueryResource<ExecutionQuery, ExecutionInfo>(_api, query);

    }
}
