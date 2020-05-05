﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Tenant
{
    public class TenantService : ITenantService
    {
        private ITenantRestService _api;

        internal TenantService(ITenantRestService api) { _api = api; }

        public QueryResource<TenantQuery, TenantInfo> Query(TenantQuery query = null) =>
            new QueryResource<TenantQuery, TenantInfo>(
                query, 
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));

        public Task Create(TenantInfo tenant) =>
            _api.Create(tenant);
    }
}