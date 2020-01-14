using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricDecisionInstance
{
    internal interface IHistoricDecisionInstanceRestService
    {
        [Get("/history/decision-instance/{id}")]
        Task<HistoricDecisionInstance> Get(string id);

        [Get("/history/decision-instance")]
        Task<List<HistoricDecisionInstance>> GetList(QueryDictionary query, int? firstResult, int? maxResults);

        [Get("/history/decision-instance/count")]
        Task<CountResult> GetListCount(QueryDictionary query);
    }
}