using Camunda.Api.Client.Resources;
using Camunda.Api.Client.ServiceEndpoints.CaseDefinition;

namespace Camunda.Api.Client.ServiceEndpoints.CaseInstance
{
    public interface ICaseInstanceService
    {
        QueryResource<CaseInstanceQuery, CaseInstanceInfo> Query(CaseInstanceQuery query = null);
        CaseInstanceResource this[string caseInstanceId] { get; }
    }
}