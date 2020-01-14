using System.Runtime.Serialization;

namespace Camunda.Api.Client.ServiceEndpoints.Message
{
    public enum MessageCorrelationResultType
    {
        [EnumMember(Value = nameof(ProcessDefinition))]
        ProcessDefinition,

        [EnumMember(Value = nameof(Execution))]
        Execution,
    }
}
