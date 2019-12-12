using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.History
{
    internal interface IHistoricCaseActivityInstanceRestService
    {
        [Get("/history/case-activity-instance/{id}")]
        Task<HistoricCaseActivityInstance> Get(string id);

        [Get("/history/case-activity-instance")]
        Task<List<HistoricCaseActivityInstance>> GetList(string caseInstanceId, int? firstResult, int? maxResults);

        [Get("/history/case-activity-instance/count")]
        Task<CountResult> GetListCount(string caseInstanceId);
    }
}