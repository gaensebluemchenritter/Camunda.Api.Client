using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ServiceEndpoints.Authorization
{
    public class AuthorizationResource
    {
        private string _authorizationId;
        private IAuthorizationRestService _api;

        internal AuthorizationResource(IAuthorizationRestService api, string authorizationId)
        {
            _api = api;
            _authorizationId = authorizationId;
        }

        public Task<AuthorizationInfo> Get() => _api.GetById(_authorizationId);

        public Task Delete() => _api.DeleteAuthorization(_authorizationId);

        public Task Update(AuthorizationUpdateQuery query) => _api.UpdateAuthorization(_authorizationId, query);
    }
}
