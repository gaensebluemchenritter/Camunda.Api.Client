using System;
using System.Collections.Generic;
using System.Text;
using Camunda.Api.Client.Resources;
using Newtonsoft.Json;

namespace Camunda.Api.Client.ServiceEndpoints.Authorization
{
    public class AuthorizationQuery : QueryParameters
    {
        /// <summary>
        /// Filter by the id of the authorization.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Filter by authorization type. (0=global, 1=grant, 2=revoke). See the User Guide for more information about authorization types.
        /// </summary>
        public AuthorizationType? Type { get; set; }

        /// <summary>
        /// Filter by a comma-separated list of userIds.
        /// </summary>
        [JsonProperty("userIdIn")]
        public List<string> UserIds = new List<string>();

        /// <summary>
        /// Filter by a comma-separated list of groupIds.
        /// </summary>
        [JsonProperty("groupIdIn")]
        public List<string> GroupIds = new List<string>();

        /// <summary>
        /// Filter by an integer representation of the resource type. See the User Guide for a list of integer representations of resource types.
        /// </summary>
        public ResourceType? ResourceType { get; set; }

        /// <summary>
        /// Filter by resource id.
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Sort the results lexicographically by a given criterion. Valid values are resourceType and resourceId. Must be used in conjunction with the sortOrder parameter.
        /// </summary>
        public AuthorizationQuerySorting? SortBy { get; set; }

        /// <summary>
        /// Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        public SortOrder? SortOrder { get; set; }
    }
}
