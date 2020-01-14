namespace Camunda.Api.Client.ServiceEndpoints.ProcessInstance
{
    public enum InstructionType
    {
        /// <summary>
        /// A cancel instruction requests cancellation of a single activity instance or all instances of one activity. 
        /// </summary>
        Cancel,
        /// <summary>
        /// A startBeforeActivity instruction requests to enter a given activity.
        /// </summary>
        StartBeforeActivity,
        /// <summary>
        /// A startAfterActivity instruction requests to execute the single outgoing sequence flow of a given activity. 
        /// </summary>
        StartAfterActivity,
        /// <summary>
        /// A startTransition instruction requests to execute a specific sequence flow.
        /// </summary>
        StartTransition,
    }
}
