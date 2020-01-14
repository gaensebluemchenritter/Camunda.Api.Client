namespace Camunda.Api.Client.ServiceEndpoints.UserTask
{
    public enum TaskSorting
    {
        Id,
        InstanceId,
        CaseInstanceId,
        DueDate,
        ExecutionId,
        CaseExecutionId,
        Assignee,
        Created,
        Description,
        Name,
        NameCaseInsensitive,
        Priority,

        ProcessVariable,
        ExecutionVariable,
        TaskVariable,
        CaseExecutionVariable,
        CaseInstanceVariable
    }
}
