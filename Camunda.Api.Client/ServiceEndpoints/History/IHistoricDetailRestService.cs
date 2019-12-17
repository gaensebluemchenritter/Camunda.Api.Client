﻿using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.History
{
    internal interface IHistoricDetailRestService
    {
        [Get("/history/detail/{id}")]
        Task<HistoricDetail> Get(string id);

        [Get("/history/detail")]
        Task<List<HistoricDetail>> GetList(QueryDictionary query, int? firstResult, int? maxResults);

        [Get("/history/detail/count")]
        Task<CountResult> GetListCount(QueryDictionary query);

        [Get("/history/detail/{id}/data")]
        Task<HttpResponseMessage> GetData(string id);
    }
}