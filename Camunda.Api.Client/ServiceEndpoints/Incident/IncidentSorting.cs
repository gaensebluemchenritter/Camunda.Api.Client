namespace Camunda.Api.Client.ServiceEndpoints.Incident
{
    public enum IncidentSorting
    {
        IncidentId,
        IncidentTimestamp,
        IncidentType,
        ExecutionId,
        ActivityId,
        ProcessInstanceId,
        ProcessDefinitionId,
        CauseIncidentId,
        RootCauseIncidentId,
        Configuration,
        TenantId
    }
}
