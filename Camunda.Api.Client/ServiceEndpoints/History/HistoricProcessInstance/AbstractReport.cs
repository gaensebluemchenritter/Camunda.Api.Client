using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricProcessInstance
{
    public abstract class AbstractReport : QueryParameters
    {
        /// <summary>
        /// Specifies the granularity of the report.
        /// </summary>
        public PeriodUnit PeriodUnit;
        /// <summary>
        /// Specifies the type of the report to retrieve.
        /// </summary>
        public ReportType ReportType;
    }
}
