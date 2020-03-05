#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;
using Refit;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.DecisionRequirementsDefinition
{
    internal interface IDecisionRequirementsDefinitionRestService
    {
        [Get("/decision-requirements-definition")]
        Task<List<DecisionRequirementsDefinitionInfo>> GetList([Body] DecisionRequirementsDefinitionQuery query,
            int? firstResult, int? maxResults);

        [Get("/decision-requirements-definition/count")]
        Task<CountResult> GetListCount([Body] DecisionRequirementsDefinitionQuery query);


        [Get("/decision-requirements-definition/{id}")]
        Task<DecisionRequirementsDefinitionInfo> GetById(string id);
        
        [Get("/decision-requirements-definition/key/{key}")]
        Task<DecisionRequirementsDefinitionInfo> GetByKey(string key);

        [Get("/decision-requirements-definition/key/{key}/tenant-id/{tenantId}")]
        Task<DecisionRequirementsDefinitionInfo> GetByKeyAndTenantId(string key, string tenantId);


        [Get("/decision-requirements-definition/{id}/xml")]
        Task<DecisionRequirementsDefinitionDiagram> GetXmlById(string id);

        [Get("/decision-requirements-definition/key/{key}/xml")]
        Task<DecisionRequirementsDefinitionDiagram> GetXmlByKey(string key);

        [Get("/decision-requirements-definition/key/{key}/tenant-id/{tenantId}/xml")]
        Task<DecisionRequirementsDefinitionDiagram> GetXmlByKeyAndTenantId(string key, string tenantId);


        [Get("/decision-requirements-definition/{id}/diagram")]
        Task<HttpResponseMessage> GetDiagramById(string id);

        [Get("/decision-requirements-definition/key/{key}/diagram")]
        Task<HttpResponseMessage> GetDiagramByKey(string key);

        [Get("decision-requirements-definition/key/{key}/tenant-id/{tenantId}/diagram")]
        Task<HttpResponseMessage> GetDiagramByKeyAndTenantId(string key, string tenantId);
    }
}
