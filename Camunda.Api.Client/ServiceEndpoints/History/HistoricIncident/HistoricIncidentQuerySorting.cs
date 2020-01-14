namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricIncident
{
    public enum HistoricIncidentQuerySorting
    {
        IncidentId,
        CreateTime,
        EndTime,
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
