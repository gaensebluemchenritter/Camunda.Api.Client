using System;
using System.Collections.Generic;
using System.Text;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Authorization
{
    public class AuthorizationUpdateQuery : QueryParameters
    {
        /// <summary>
        /// An integer holding the permissions provided by this authorization.
        /// </summary>
        public int? Permissions { get; set; }

        /// <summary>
        /// The id of the user this authorization has been created for. The value "*" represents a global authorization ranging over all users.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The id of the group this authorization has been created for.
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// An integer representing the resource type. See the User Guide for a list of integer representations of resource types.
        /// </summary>
        public ResourceType? ResourceType { get; set; }

        /// <summary>
        /// The resource Id. The value "*" represents an authorization ranging over all instances of a resource.
        /// </summary>
        public string ResourceId { get; set; }
    }
}
