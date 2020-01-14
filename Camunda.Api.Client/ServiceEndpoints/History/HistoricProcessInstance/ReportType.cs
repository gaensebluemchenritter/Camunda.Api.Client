using System.Runtime.Serialization;

namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricProcessInstance
{
    public enum ReportType
    {
        [EnumMember(Value = "duration")]
        Duration,

        [EnumMember(Value = "count")]
        Count
    }
}
