#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.DecisionRequirementsDefinition
{
    public class DecisionRequirementsDefinitionQuery : QueryParameters
    {
        /// <summary>
        /// Filter by decision requirements definition id.
        /// </summary>
        public string DecisionRequirementsDefinitionId;

        /// <summary>
        /// Filter by decision requirements definition ids.
        /// </summary>
        public List<string> DecisionRequirementsDefinitionIdIn;

        /// <summary>
        /// Filter by decision requirements definition name.
        /// </summary>
        public string Name;

        /// <summary>
        /// Filter by decision requirements definition names that the parameter is a substring of.
        /// </summary>
        public string NameLike;

        /// <summary>
        /// Filter by the deployment the id belongs to.
        /// </summary>
        public string DeploymentId;

        /// <summary>
        /// Filter by decision requirements definition key, i.e., the id in the DMN 1.1 XML. Exact match.
        /// </summary>
        public string Key;

        /// <summary>
        /// Filter by decision requirements definition keys that the parameter is a substring of.
        /// </summary>
        public string KeyLike;

        /// <summary>
        /// Filter by decision requirements definition category. Exact match.
        /// </summary>
        public string Category;

        /// <summary>
        /// Filter by decision requirements definition categories that the parameter is a substring of.
        /// </summary>
        public string CategoryLike;

        /// <summary>
        /// Filter by decision requirements definition version.
        /// </summary>
        public int? Version;

        /// <summary>
        /// Only include those decision requirements definitions that are latest versions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? LatestVersion;

        /// <summary>
        /// Filter by the name of the decision requirements definition resource. Exact match.
        /// </summary>
        public string ResourceName;

        /// <summary>
        /// Filter by names of those decision requirements definition resources that the parameter is a substring of.
        /// </summary>
        public string ResourceNameLike;

        /// <summary>
        /// Filter by a comma-separated list of tenant ids. A decision requirements definition must have one of the given tenant ids.
        /// </summary>
        public List<string> TenantIdIn;

        /// <summary>
        /// Only include decision requirements definitions which belong to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? WithoutTenantId;

        /// <summary>
        /// Include decision requirements definitions which belong to no tenant. Can be used in combination with tenantIdIn. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? IncludeDecisionRequirementsDefinitionsWithoutTenantId;

        /// <summary>
        /// Sort the results lexicographically by a given criterion.
        /// Valid values are category, key, id, name, version, deploymentId and tenantId. Must be used in conjunction with the sortOrder parameter.
        /// </summary>
        public DecisionRequirementsDefinitionSorting? SortBy;

        /// <summary>
        /// Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        public SortOrder? SortOrder;
    }
}
