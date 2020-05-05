﻿using System;

namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricProcessInstance
{
    public class HistoricProcessInstance
    {
        /// <summary>
        /// The id of the process instance.
        /// </summary>
        public string Id;
        /// <summary>
        /// The business key of the process instance.
        /// </summary>
        public string BusinessKey;
        /// <summary>
        /// The id of the process definition that this process instance belongs to.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The key of the process definition that this process instance belongs to.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// The name of the process definition that this process instance belongs to.
        /// </summary>
        public string ProcessDefinitionName;
        /// <summary>
        /// The time the instance was started.
        /// </summary>
        public DateTime StartTime;
        /// <summary>
        /// The time the instance ended.
        /// </summary>
        public DateTime EndTime;
        /// <summary>
        /// The time the instance took to finish (in milliseconds).
        /// </summary>
        public long DurationInMillis;
        /// <summary>
        /// The id of the user who started the process instance.
        /// </summary>
        public string StartUserId;
        /// <summary>
        /// The id of the initial activity that was executed (e.g., a start event).
        /// </summary>
        public string StartActivityId;
        /// <summary>
        /// The provided delete reason in case the process instance was canceled during execution./// </summary>
        public string DeleteReason;
        /// <summary>
        /// The id of the parent process instance, if it exists.
        /// </summary>
        public string SuperProcessInstanceId;
        /// <summary>
        /// The id of the parent case instance, if it exists.
        /// </summary>
        public string SuperCaseInstanceId;
        /// <summary>
        /// The id of the parent case instance, if it exists.
        /// </summary>
        public string CaseInstanceId;
        /// <summary>
        /// The tenant id of the process instance.
        /// </summary>
        public string TenantId;
        /// <summary>
        /// Last state of the process instance.
        /// </summary>
        public ProcessInstanceState State;

        public override string ToString() => Id;
    }
}