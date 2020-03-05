using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Batch
{
    public interface IBatchService
    {
        QueryResource<BatchQuery, BatchInfo> Query(BatchQuery query = null);
        BatchResource this[string batchId] { get; }
    }
}