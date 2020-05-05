#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;
using Camunda.Api.Client.ServiceEndpoints.CaseDefinition;
using Camunda.Api.Client.ServiceEndpoints.History.HistoricCaseActivityInstance;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.CaseInstance
{
    public class CaseInstanceService : ICaseInstanceService
    {
        private ICaseInstanceRestService _api;

        internal CaseInstanceService(ICaseInstanceRestService api)
        {
            _api = api;
        }

        public QueryResource<CaseInstanceQuery, CaseInstanceInfo> Query(CaseInstanceQuery query = null) =>
            new QueryResource<CaseInstanceQuery, CaseInstanceInfo>(
                query,
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));

        /// <param name="caseInstanceId">Id of specific case instance</param>
        public CaseInstanceResource this[string caseInstanceId] => new CaseInstanceResource(_api, caseInstanceId);
    }
}
