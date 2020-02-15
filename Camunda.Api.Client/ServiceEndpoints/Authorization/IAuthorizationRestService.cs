using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;
using Refit;

namespace Camunda.Api.Client.ServiceEndpoints.Authorization
{
    internal interface IAuthorizationRestService
    {
        [Get("/authorization")]
        Task<List<AuthorizationInfo>> GetList([Body] AuthorizationQuery query, int? firstResult, int? maxResults);

        [Get("/authorization/count")]
        Task<CountResult> GetListCount([Body] AuthorizationQuery query);

        [Get("/authorization/{id}")]
        Task<AuthorizationInfo> GetById(string id);

        [Get("/authorization/check")]
        Task<AuthorizationCheckInfo> CheckAuthorization([Body] AuthorizationCheckQuery query);

        [Post("/authorization/create")]
        Task<List<AuthorizationInfo>> CreateAuthorization([Body] AuthorizationCreateQuery query);

        [Put("/authorization/{id}")]
        Task UpdateAuthorization(string id, [Body] AuthorizationUpdateQuery query);

        [Delete("/authorization/{id}")]
        Task DeleteAuthorization(string id);
    }
}
