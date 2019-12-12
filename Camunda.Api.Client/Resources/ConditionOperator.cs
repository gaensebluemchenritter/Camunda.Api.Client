using System.Runtime.Serialization;

namespace Camunda.Api.Client.Resources
{
    public enum ConditionOperator
    {
        [EnumMember(Value = "eq")]
        Equals,
        [EnumMember(Value = "neq")]
        NotEquals,
        [EnumMember(Value = "gt")]
        GreaterThan,
        [EnumMember(Value = "gteq")]
        GreaterThanOrEquals,
        [EnumMember(Value = "lt")]
        LessThan,
        [EnumMember(Value = "lteq")]
        LessThanOrEquals,
        [EnumMember(Value = "like")]
        Like
    }
}
