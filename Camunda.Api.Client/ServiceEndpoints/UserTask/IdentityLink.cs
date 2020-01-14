namespace Camunda.Api.Client.ServiceEndpoints.UserTask
{
    public class IdentityLink
    {
        /// <summary>
        /// The id of the user to link to the task. If you set this parameter, you have to omit groupId.
        /// </summary>
        public string UserId;
        /// <summary>
        /// The id of the group to link to the task. If you set this parameter, you have to omit userId.
        /// </summary>
        public string GroupId;
        /// <summary>
        /// The type of the identity link. Can be any defined type. assignee and owner are reserved types for the task assignee and owner.
        /// <seealso cref="IdentityLinkType"/>
        /// </summary>
        public string Type;

        public override string ToString()
        {
            return UserId ?? GroupId ?? Type;
        }
    }
}
