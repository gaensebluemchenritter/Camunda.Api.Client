﻿using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.CaseExecution
{
    public class CaseExecutionService
    {
        private ICaseExecutionRestService _api;

        internal CaseExecutionService(ICaseExecutionRestService api)
        {
            _api = api;
        }

        public CaseExecutionResource this[string caseExecutionId] => new CaseExecutionResource(_api, caseExecutionId);

        public QueryResource<CaseExecutionQuery, CaseExecutionInfo> Query(CaseExecutionQuery query = null) =>
            new QueryResource<CaseExecutionQuery, CaseExecutionInfo>(_api, query);

    }
}