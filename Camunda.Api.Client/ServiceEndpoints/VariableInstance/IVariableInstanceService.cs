namespace Camunda.Api.Client.ServiceEndpoints.VariableInstance
{
    public interface IVariableInstanceService
    {
        /// <param name="variableInstanceId">The id of the variable instance.</param>
        VariableInstanceResource this[string variableInstanceId] { get; }

        VariableInstanceQueryResource Query(VariableInstanceQuery query = null);
    }
}