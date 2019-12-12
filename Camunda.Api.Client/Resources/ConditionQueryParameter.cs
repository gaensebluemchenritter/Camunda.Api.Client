namespace Camunda.Api.Client.Resources
{
    public class ConditionQueryParameter
    {
        /// <summary>
        /// Comparison operator to be used.
        /// </summary>
        public ConditionOperator Operator;

        /// <summary>
        /// Value may be String, Number or Boolean
        /// </summary>
        public object Value;
    }
}
