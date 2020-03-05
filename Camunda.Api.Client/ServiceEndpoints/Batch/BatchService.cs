#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.Batch
{
    public class BatchService : IBatchService
    {
        private IBatchRestService _api;

        internal BatchService(IBatchRestService api)
        {
            _api = api;
        }

        public QueryResource<BatchQuery, BatchInfo> Query(BatchQuery query = null) =>
        new QueryResource<BatchQuery, BatchInfo>(
            query,
            (q, f, m) => _api.GetList(q, f, m),
            q => _api.GetListCount(q));

        public BatchResource this[string batchId] => new BatchResource(_api, batchId);
    }
}
