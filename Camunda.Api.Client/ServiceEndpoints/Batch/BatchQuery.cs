#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.Batch
{
    public class BatchQuery : QueryParameters
    {
        /// <summary>
        /// Filter by batch id.
        /// </summary>
        public string BatchId { get; set; }

        /// <summary>
        /// Filter by batch type. See the User Guide for more information about batch types.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Filter by a comma-separated list of tenant ids. A batch matches if it has one of the given tenant ids.
        /// </summary>
        public List<string> TenantIdIn { get; set; }

        /// <summary>
        /// Only include batches which belong to no tenant. Value can effectively only be true, as false is the default behavior.
        /// </summary>
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// indicates whether only active or suspended batches should be included.
        /// When the value is set to true, only suspended batches will be returned and when the value is set to false, only active batches will be returned.
        /// </summary>
        public bool Suspended { get; set; }

        /// <summary>
        /// Sort the results lexicographically by a given criterion. Valid values are batchId and tenantId. Must be used in conjunction with the sortOrder parameter.
        /// </summary>
        public BatchSortBy? SortBy { get; set; }

        /// <summary>
        /// Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        public SortOrder? SortOrder { get; set; }
    }
}
