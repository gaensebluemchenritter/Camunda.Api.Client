using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Authorization
{
    public class AuthorizationService : IAuthorizationService
    {
        private IAuthorizationRestService _api;

        internal AuthorizationService(IAuthorizationRestService api)
        {
            _api = api;
        }

        public QueryResource<AuthorizationQuery, AuthorizationInfo> Query(AuthorizationQuery query = null) =>
            new QueryResource<AuthorizationQuery, AuthorizationInfo>(_api, query);

        public AuthorizationResource this[string authorizationId] => new AuthorizationResource(_api, authorizationId);

        public Task<AuthorizationCheckInfo> CheckAuthorization(AuthorizationCheckQuery query) =>
            _api.CheckAuthorization(query);

        public Task<List<AuthorizationInfo>> CreateAuthorization(AuthorizationCreateQuery query) =>
            _api.CreateAuthorization(query);
    }
}
