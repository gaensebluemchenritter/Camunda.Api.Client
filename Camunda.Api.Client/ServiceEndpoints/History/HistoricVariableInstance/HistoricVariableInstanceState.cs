using System.Runtime.Serialization;

namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricVariableInstance
{
    public enum HistoricVariableInstanceState
    {
        /// <summary>
        /// Created
        /// </summary>
        [EnumMember(Value = "CREATED")]
        Created,

        /// <summary>
        /// Deleted
        /// </summary>
        [EnumMember(Value = "DELETED")]
        Deleted,
    }
}
