using System.Collections.Generic;

namespace Camunda.Api.Client.ServiceEndpoints.ProcessInstance
{
    public class ProcessInstanceModificationInstruction
    {
        /// <summary>
        /// Mandatory.
        /// </summary>
        public InstructionType Type;
        /// <summary>
        /// Can be used with instructions of types startBeforeActivity, startAfterActivity, and cancel. Specifies the activity the instruction targets.
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// Can be used with instructions of types startTransition. Specifies the sequence flow to start.
        /// </summary>
        public string TransitionId;
        /// <summary>
        /// Can be used with instructions of type cancel. Specifies the activity instance to cancel. 
        /// Valid values are the activity instance IDs supplied by the <see cref="ProcessInstanceResource.GetActivityInstance"/> request.
        /// </summary>
        public string ActivityInstanceId;
        /// <summary>
        /// Can be used with instructions of type cancel. Specifies the transition instance to cancel. Valid values are the transition instance IDs supplied by the <see cref="ProcessInstanceResource.GetActivityInstance"/> request.
        /// </summary>
        public string TransitionInstanceId;
        /// <summary>
        /// Can be used with instructions of type startBeforeActivity, startAfterActivity, and startTransition. Valid values are the activity instance IDs supplied by the <see cref="ProcessInstanceResource.GetActivityInstance"/> request.
        /// </summary>
        /// <remarks>
        /// If there are multiple parent activity instances of the targeted activity, this specifies the ancestor scope in which hierarchy the activity/transition is to be instantiated.
        /// Example: When there are two instances of a subprocess and an activity contained in the subprocess is to be started, this parameter allows to specifiy under which subprocess instance the activity should be started.
        /// </remarks>
        public string AncestorActivityInstanceId;
        /// <summary>
        /// Can be used with instructions of type startBeforeActivity, startAfterActivity, and startTransition. An object containing variable key-value pairs.
        /// </summary>
        public Dictionary<string, TriggerVariableValue> Variables = new Dictionary<string, TriggerVariableValue>();
    }
}
