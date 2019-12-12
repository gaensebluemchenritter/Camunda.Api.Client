using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.History
{
    internal interface IHistoricIncidentRestService
    {
        [Get("/history/incident")]
        Task<List<HistoricIncident>> GetList(QueryDictionary query, int? firstResult, int? maxResults);

        [Get("/history/incident/count")]
        Task<CountResult> GetListCount(QueryDictionary query);
    }
}
