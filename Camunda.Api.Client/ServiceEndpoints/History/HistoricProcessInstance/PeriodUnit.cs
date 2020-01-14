using System.Runtime.Serialization;

namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricProcessInstance
{
    public enum PeriodUnit
    {
        /// <summary>
        /// Represents a unit for a quarter of the year.
        /// </summary>
        [EnumMember(Value = "quarter")]
        Quarter,

        /// <summary>
        /// Represents a unit for a month of the year.
        /// </summary>
        [EnumMember(Value = "month")]
        Month
    }
}
