using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.CaseExecution
{
    public interface ICaseExecutionService
    {
        CaseExecutionResource this[string caseExecutionId] { get; }
        QueryResource<CaseExecutionQuery, CaseExecutionInfo> Query(CaseExecutionQuery query = null);
    }
}