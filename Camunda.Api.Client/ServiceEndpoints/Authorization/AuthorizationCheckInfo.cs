using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.ServiceEndpoints.Authorization
{
    public class AuthorizationCheckInfo
    {
        /// <summary>
        /// Name of the permission which was checked.
        /// </summary>
        public string PermissionName { get; set; }

        /// <summary>
        /// The name of the resource for which the permission check was performed.
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// The id of the resource for which the permission check was performed.
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// true / false for isAuthorized.
        /// </summary>
        public bool IsAuthorized { get; set; }
    }
}
