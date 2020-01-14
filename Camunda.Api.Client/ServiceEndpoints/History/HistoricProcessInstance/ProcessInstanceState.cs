using System.Runtime.Serialization;

namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricProcessInstance
{
    public enum ProcessInstanceState
    {
        /// <summary>
        /// Running process instance
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,
        /// <summary>
        /// Suspended process instances
        /// </summary>
        [EnumMember(Value = "SUSPENDED")]
        Suspended,
        /// <summary>
        /// Suspended process instances
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,
        /// <summary>
        /// Suspended process instances
        /// </summary>
        [EnumMember(Value = "EXTERNALLY_TERMINATED")]
        ExternallyTerminated,
        /// <summary>
        /// Terminated internally, for instance by terminating boundary event
        /// </summary>
        [EnumMember(Value = "INTERNALLY_TERMINATED")]
        InternallyTerminated,
    }
}
