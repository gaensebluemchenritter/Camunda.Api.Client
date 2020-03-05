#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.Batch
{
    public class BatchResource
    {
        private string _batchId;
        private IBatchRestService _api;

        internal BatchResource(IBatchRestService api, string batchId)
        {
            _api = api;
            _batchId = batchId;
        }

        /// <summary>
        /// retrieves a single batch corresponding to the batchId in the engine
        /// </summary>
        public Task<BatchInfo> Get() => _api.Get(_batchId);

        /// <summary>
        /// activates/suspends a single batch corresponding to the batchId
        /// </summary>
        /// <param name="suspended"></param>
        /// <returns></returns>
        public Task ActivateSuspend(BatchSuspended suspended) => _api.ActivateSuspend(_batchId, suspended);

        /// <summary>
        /// deletes a single batch corresponding to the batchId
        /// </summary>
        /// <returns></returns>
        public Task Delete(BatchDelete delete) => _api.Delete(_batchId, delete);
    }
}
