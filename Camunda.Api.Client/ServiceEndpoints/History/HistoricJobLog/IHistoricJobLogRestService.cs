using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricJobLog
{
    internal interface IHistoricJobLogRestService
    {
        [Get("/history/job-log/{id}")]
        Task<HistoricJobLog> Get(string id);

        [Post("/history/job-log")]
        Task<List<HistoricJobLog>> GetList([Body] HistoricJobLogQuery query, int? firstResult, int? maxResults);

        [Post("/history/job-log/count")]
        Task<CountResult> GetListCount([Body] HistoricJobLogQuery query);

        [Get("/history/job-log/{id}/stacktrace")]
        Task<HttpResponseMessage> GetStacktrace(string id);
    }
}
