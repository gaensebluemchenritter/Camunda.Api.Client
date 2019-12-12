﻿using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;
using Camunda.Api.Client.ServiceEndpoints.Batch;

namespace Camunda.Api.Client.ServiceEndpoints.History
{
    internal interface IHistoricProcessInstanceRestService
    {
        [Get("/history/process-instance/{id}")]
        Task<HistoricProcessInstance> Get(string id);

        [Post("/history/process-instance")]
        Task<List<HistoricProcessInstance>> GetList([Body] HistoricProcessInstanceQuery query, int? firstResult, int? maxResults);

        [Post("/history/process-instance/count")]
        Task<CountResult> GetListCount([Body] HistoricProcessInstanceQuery query);

        [Delete("/history/process-instance/{id}")]
        Task Delete(string id);

        [Get("/history/process-instance/report")]
        Task<List<DurationReportResult>> GetDurationReport(HistoricProcessInstanceReport historicProcessInstanceReport);

        [Post("/history/process-instance/delete")]
        Task<BatchInfo> DeleteAsync([Body] DeleteHistoricProcessInstances deleteHistoricProcessInstances);
    }
}
