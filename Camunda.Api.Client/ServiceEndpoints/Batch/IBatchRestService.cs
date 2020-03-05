#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;
using Refit;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.Batch
{
    internal interface IBatchRestService
    {
        [Get("/batch")]
        Task<List<BatchInfo>> GetList([Body] BatchQuery query, int? firstResult, int? maxResults);

        [Get("/batch/{id}")]
        Task<BatchInfo> Get(string id);

        [Get("/batch/count")]
        Task<CountResult> GetListCount([Body] BatchQuery query);

        [Put("/batch/{id}/suspended")]
        Task ActivateSuspend(string id, [Body] BatchSuspended suspended);

        [Delete("/batch/{id}")]
        Task Delete(string id, [Body] BatchDelete delete);

        [Get("/batch/statistics")]
        Task<List<BatchStatisticsInfo>> GetStatistics([Body] BatchQuery query, int? firstResult, int? MaxResults);

        [Get("/batch/statistics/count")]
        Task<CountResult> GetStatisticsCount([Body] BatchQuery query);
    }
}
