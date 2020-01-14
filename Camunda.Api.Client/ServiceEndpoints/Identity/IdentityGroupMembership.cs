using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.ServiceEndpoints.Identity
{
    public class IdentityGroupMembership
    {
        public IdentityGroupMembership()
        {
            Groups = new List<IdentityGroup>();
            GroupUsers = new List<IdentityUser>();
        }
        /// <summary>
        /// List of groups the user is a member of
        /// </summary>
        [JsonProperty("groups")]
        public List<IdentityGroup> Groups { get; set; }
        /// <summary>
        /// List of users who are members of any of the groups 
        /// </summary>
        [JsonProperty("groupUsers")]
        public List<IdentityUser> GroupUsers { get; set; }
    }
}
