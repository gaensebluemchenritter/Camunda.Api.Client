using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Incident
{
    public interface IIncidentService
    {
        QueryResource<IncidentQuery, IncidentInfo> Query(IncidentQuery query = null);
    }
}