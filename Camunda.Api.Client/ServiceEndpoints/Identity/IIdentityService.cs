using System.Threading.Tasks;

namespace Camunda.Api.Client.ServiceEndpoints.Identity
{
    public interface IIdentityService
    {
        /// <param name="userId">The id of the user whose group membership is to be retrieved.</param>
        Task<IdentityGroupMembership> GetMembership(string userId);

        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <param name="username">The user's profile</param>
        /// <param name="password">The user's password.</param>
        /// <returns></returns>
        Task<IdentityVerifiedUser> Verify(string username, string password);
    }
}