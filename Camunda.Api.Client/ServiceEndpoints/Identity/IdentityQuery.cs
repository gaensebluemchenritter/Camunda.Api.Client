using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Identity
{
    public class IdentityQuery : QueryParameters
    {
        /// <summary>
        /// The id of the user to get the groups for.
        /// </summary>
        public string UserId;
    }
}
