using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.User
{
    public class UserService : IUserService
    {
        private IUserRestService _api;

        internal UserService(IUserRestService api) { _api = api; }

        public QueryResource<UserQuery, UserProfileInfo> Query(UserQuery query = null) =>
            new QueryResource<UserQuery, UserProfileInfo>(
                query, 
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));

        /// <param name="userId">The id of the user to be retrieved.</param>
        public UserResource this[string userId] => new UserResource(_api, userId);

        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <param name="profile">The user's profile</param>
        /// <param name="password">The user's password.</param>
        /// <returns></returns>
        public Task Create(UserProfileInfo profile, string password) => 
            _api.Create(new CreateUser() { Profile = profile, Credentials = new UserCredentialsInfo { Password = password } });

    }
}
