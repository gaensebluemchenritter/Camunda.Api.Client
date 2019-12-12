namespace Camunda.Api.Client.Resources
{
    public class VariableOrder
    {
        public string VariableName;
        public VariableType Type;

        public VariableOrder(string variableName, VariableType variableType)
        {
            VariableName = variableName;
            Type = variableType;
        }
    }
}
