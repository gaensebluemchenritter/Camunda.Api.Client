﻿using System.Runtime.Serialization;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricVariableInstance
{
    public class HistoricVariableInstance : VariableValue
    {
        /// <summary>
        /// The id of the variable instance.
        /// </summary>
        public string Id;
        /// <summary>
        /// The name of the variable instance.
        /// </summary>
        public string Name;
        /// <summary>
        /// The key of the process definition the variable instance belongs to.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// The id of the process definition the variable instance belongs to.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The id the process instance belongs to.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The execution id the variable instance belongs to.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// The id of the activity instance in which the variable is valid.
        /// </summary>
        public string ActivityInstanceId;
        /// <summary>
        /// The key of the case definition the variable instance belongs to.
        /// </summary>
        public string CaseDefinitionKey;
        /// <summary>
        /// The id of the case definition the variable instance belongs to.
        /// </summary>
        public string CaseDefinitionId;
        /// <summary>
        /// The case instance id the variable instance belongs to.
        /// </summary>
        public string CaseInstanceId;
        /// <summary>
        /// The case execution id the variable instance belongs to.
        /// </summary>
        public string CaseExecutionId;
        /// <summary>
        /// The id of the task the variable instance belongs to.
        /// </summary>
        public string TaskId;
        /// <summary>
        /// The id of the tenant that this variable instance belongs to.
        /// </summary>
        public string ErrorMessage;
        /// <summary>
        /// An error message in case a Java Serialized Object could not be de-serialized.
        /// </summary>
        public string TenantId;
        /// <summary>
        /// The current state of the variable. 
        /// </summary>
        public HistoricVariableInstanceState State;

        public override string ToString() => $"{Name} = {base.ToString()}";
    }
}
