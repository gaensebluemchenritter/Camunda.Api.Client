﻿#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.CaseInstance
{
    public enum CaseInstanceSorting
    {
        CaseInstanceId,
        CaseDefinitionKey,
        CaseDefinitionId,
        TenantId
    }
}
