using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.ProcessDefinition
{
    public interface IProcessDefinitionService
    {
        ProcessDefinitionResource this[string processDefinitionId] { get; }
        ProcessDefinitionResource ByKey(string processDefinitionKey);
        ProcessDefinitionResource ByKey(string processDefinitionKey, string tenantId);
        QueryResource<ProcessDefinitionQuery, ProcessDefinitionInfo> Query(ProcessDefinitionQuery query = null);

        /// <summary>
        /// Retrieves runtime statistics of the process engine grouped by process definitions. These statistics include the number of running process instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type.
        /// </summary>
        /// <param name="includeFailedJobs">Whether to include the number of failed jobs in the result or not.</param>
        /// <param name="includeIncidents">If this property has been set to true the result will include the corresponding number of incidents for each occurred incident type. If it is set to false, the incidents will not be included in the result.</param>
        /// <remarks>This does not include historic data.</remarks>
        Task<List<ProcessDefinitionStatisticsResult>> GetStatistics(bool includeFailedJobs, bool includeIncidents);

        /// <summary>
        /// Retrieves runtime statistics of the process engine grouped by process definitions. These statistics include the number of running process instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type.
        /// </summary>
        /// <param name="includeFailedJobs">Whether to include the number of failed jobs in the result or not.</param>
        /// <param name="includeIncidentsForType">If this property has been set with any incident type (i.e. a string value) the result will only include the number of incidents for the assigned incident type.</param>
        /// <remarks>This does not include historic data.</remarks>
        Task<List<ProcessDefinitionStatisticsResult>> GetStatistics(bool includeFailedJobs, string includeIncidentsForType);

        /// <summary>
        /// Retrieves runtime statistics of the process engine grouped by process definitions. These statistics include the number of running process instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type.
        /// </summary>
        /// <param name="includeFailedJobs">Whether to include the number of failed jobs in the result or not.</param>
        /// <remarks>This does not include historic data.</remarks>
        Task<List<ProcessDefinitionStatisticsResult>> GetStatistics(bool includeFailedJobs);

        /// <summary>
        /// Deletes a process definition from a deployment by id.
        /// </summary>
        /// <param name="processDefinitionId"></param>
        /// <param name="cascade"><c>true</c>, if all process instances, historic process instances and jobs for this process definition should be deleted.</param>
        /// <param name="skipCustomListeners"><c>true</c>, if only the built-in ExecutionListeners should be notified with the end event.</param>
        /// <returns></returns>
        Task Delete(string processDefinitionId, bool cascade, bool skipCustomListeners);
    }
}