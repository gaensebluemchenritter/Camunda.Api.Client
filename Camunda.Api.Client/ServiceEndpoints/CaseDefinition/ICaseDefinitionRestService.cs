using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;
using Refit;

namespace Camunda.Api.Client.ServiceEndpoints.CaseDefinition
{
    internal interface ICaseDefinitionRestService
    {
        [Get("/case-definition")]
        Task<List<CaseDefinitionInfo>> GetList(QueryDictionary query, int? firstResult, int? maxResults);
        [Get("/case-definition/count")]
        Task<CountResult> GetListCount(QueryDictionary query);


        [Get("/case-definition/{id}")]
        Task<CaseDefinitionInfo> GetById(string id);
        [Get("/case-definition/key/{key}")]
        Task<CaseDefinitionInfo> GetByKey(string key);
        [Get("/case-definition/key/{key}/tenant-id/{tenantId}")]
        Task<CaseDefinitionInfo> GetByKeyAndTenantId(string key, string tenantId);


        [Get("/case-definition/{id}/xml")]
        Task<CaseDefinitionDiagram> GetXmlById(string id);
        [Get("/case-definition/key/{key}/xml")]
        Task<CaseDefinitionDiagram> GetXmlByKey(string key);
        [Get("/case-definition/key/{key}/tenant-id/{tenantId}/xml")]
        Task<CaseDefinitionDiagram> GetXmlByKeyAndTenantId(string key, string tenantId);


        [Get("/case-definition/{id}/diagram")]
        Task<HttpResponseMessage> GetDiagramById(string id);
        [Get("/case-definition/key/{key}/diagram")]
        Task<HttpResponseMessage> GetDiagramByKey(string key);
        [Get("/case-definition/key/{key}/tenant-id/{tenantId}/diagram")]
        Task<HttpResponseMessage> GetDiagramByKeyAndTenantId(string key, string tenantId);


        [Post("/case-definition/{id}/create")]
        Task<CaseInstanceInfo> CreateCaseInstanceById(string id, [Body] CreateCaseInstance parameters);
        [Post("/case-definition/key/{key}/create")]
        Task<CaseInstanceInfo> CreateCaseInstanceByKey(string key, [Body] CreateCaseInstance parameters);
        [Post("/case-definition/key/{key}/tenant-id/{tenantId}/create")]
        Task<CaseInstanceInfo> CreateCaseInstanceByKeyAndTenantId(string key, string tenantId, [Body] CreateCaseInstance parameters);


        [Put("/case-definition/{id}/history-time-to-live")]
        Task UpdateHistoryTimeToLiveById(string id, [Body] CaseDefinitionHistoryTimeToLive historyTimeToLive);
        [Put("/case-definition/key/{key}/history-time-to-live")]
        Task UpdateHistoryTimeToLiveByKey(string key, [Body] CaseDefinitionHistoryTimeToLive historyTimeToLive);
        [Put("/case-definition/key/{key}/tenant-id/{tenantId}/history-time-to-live")]
        Task UpdateHistoryTimeToLiveByKeyAndTenantId(string key, string tenantId, [Body] CaseDefinitionHistoryTimeToLive historyTimeToLive);
    }
}
