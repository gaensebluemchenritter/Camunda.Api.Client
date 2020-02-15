using System;
using System.Collections.Generic;
using System.Text;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Authorization
{
    public class AuthorizationCheckQuery : QueryParameters
    {
        /// <summary>
        /// String value representing the permission name to check for. Required
        /// </summary>
        public string PermissionName { get; set; }

        /// <summary>
        /// String value for the name of the resource to check permissions for. Required
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// resource type to check permissions for. Required
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// The id of the resource to check permissions for. If left blank, a check for global permissions on the resource is performed. Optional
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// The id of the user to check permissions for. The currently authenticated user must have a READ permission for the Authorization resource.
        /// If userId is blank, a check for the currently authenticated user is performed. Optional
        /// </summary>
        public string UserId { get; set; }
    }
}
