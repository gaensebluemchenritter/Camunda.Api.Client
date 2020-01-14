using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.User
{
    public interface IUserService
    {
        QueryResource<UserQuery, UserProfileInfo> Query(UserQuery query = null);

        /// <param name="userId">The id of the user to be retrieved.</param>
        UserResource this[string userId] { get; }

        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <param name="profile">The user's profile</param>
        /// <param name="password">The user's password.</param>
        /// <returns></returns>
        Task Create(UserProfileInfo profile, string password);
    }
}