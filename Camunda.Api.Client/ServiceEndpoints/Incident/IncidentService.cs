using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Incident
{
    public class IncidentService : IIncidentService
    {
        private IIncidentRestService _api;

        internal IncidentService(IIncidentRestService api)
        {
            _api = api;
        }

        public QueryResource<IncidentQuery, IncidentInfo> Query(IncidentQuery query = null) =>
            new QueryResource<IncidentQuery, IncidentInfo>(
                query, 
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));
    }
}
