using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ServiceEndpoints.History
{
    internal interface IHistoricCaseDefinitionRestService
    {
        [Get("/history/case-definition/{id}/statistics")]
        Task<List<HistoricCaseDefinitionStatisticsResult>> GetActivityStatistics(string id);
    }
}