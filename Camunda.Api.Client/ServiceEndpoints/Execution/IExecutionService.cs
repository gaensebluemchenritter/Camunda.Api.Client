using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Execution
{
    public interface IExecutionService
    {
        ExecutionResource this[string executionId] { get; }
        QueryResource<ExecutionQuery, ExecutionInfo> Query(ExecutionQuery query = null);
    }
}