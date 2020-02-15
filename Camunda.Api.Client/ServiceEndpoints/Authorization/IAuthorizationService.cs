using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Authorization
{
    public interface IAuthorizationService
    {
        QueryResource<AuthorizationQuery, AuthorizationInfo> Query(AuthorizationQuery query = null);
        AuthorizationResource this[string authorizationId] { get; }
        Task<AuthorizationCheckInfo> CheckAuthorization(AuthorizationCheckQuery query);
        Task<List<AuthorizationInfo>> CreateAuthorization(AuthorizationCreateQuery query);
    }
}