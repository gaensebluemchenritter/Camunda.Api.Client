#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.DecisionRequirementsDefinition
{
    public class DecisionRequirementsDefinitionInfo
    {
        /// <summary>
        /// The id of the decision requirements definition.
        /// </summary>
        public string Id;

        /// <summary>
        /// The key of the decision requirements definition.
        /// </summary>
        public string Key;

        /// <summary>
        /// The category of the decision requirements definition.
        /// </summary>
        public string Category;

        /// <summary>
        /// The name of the decision requirements definition.
        /// </summary>
        public string Name;

        /// <summary>
        /// The version of the decision requirements definition that the engine assigned to it.
        /// </summary>
        public int Version;

        /// <summary>
        /// The file name of the decision requirements definition.
        /// </summary>
        public string Resource;

        /// <summary>
        /// The deployment id of the decision requirements definition.
        /// </summary>
        public string DeploymentId;

        /// <summary>
        /// The tenant id of the decision requirements definition.
        /// </summary>
        public string TenantId;
    }
}
