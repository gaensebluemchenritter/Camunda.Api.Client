using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricCaseActivityInstance
{
    public class HistoricCaseActivityInstanceQuery : SortableQuery<HistoricCaseActivityInstanceQuerySorting, HistoricCaseActivityInstanceQuery>
    {
        /// <summary>
        /// Filter by case instance id.
        /// </summary>
        public string CaseInstanceId;
    }
}