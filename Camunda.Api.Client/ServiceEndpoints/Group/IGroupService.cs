using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Group
{
    public interface IGroupService
    {
        QueryResource<GroupQuery, GroupInfo> Query(GroupQuery query = null);

        /// <param name="groupId">The id of the group to be retrieved.</param>
        GroupResource this[string groupId] { get; }

        /// <summary>
        /// Create a new group.
        /// </summary>
        Task Create(GroupInfo group);
    }
}