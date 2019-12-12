﻿using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.History
{
    public class HistoricCaseInstanceService
    {
        private IHistoricCaseInstanceRestService _api;

        internal HistoricCaseInstanceService(IHistoricCaseInstanceRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricCaseInstanceQuery, HistoricCaseInstance> Query(HistoricCaseInstanceQuery query = null) =>
            new QueryResource<HistoricCaseInstanceQuery, HistoricCaseInstance>(_api, query);
        
        /// <param name="caseInstanceId">The id of the historic case instance to be retrieved.</param>
        public HistoricCaseInstanceResource this[string caseInstanceId] => new HistoricCaseInstanceResource(_api, caseInstanceId);
    }
}