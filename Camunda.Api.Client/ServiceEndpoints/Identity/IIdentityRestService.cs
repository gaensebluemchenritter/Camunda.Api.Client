using System.Collections.Generic;
using Refit;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Identity
{
    internal interface IIdentityRestService
	{
		[Get("/identity/groups")]
		Task<IdentityGroupMembership> GetMembership(QueryDictionary query);

		[Post("/identity/verify")]
		Task<IdentityVerifiedUser> Verify([Body]IdentityUserCredentials credentials);

        [Get("/identity/password-policy")]
        Task<IdentityPasswordPolicy> GetPasswordPolicy();

        [Post("/identity/password-policy")]
        Task<IdentityPasswordValidationResult> ValidatePassword([Body] IdentityPassword password);
    }
}
