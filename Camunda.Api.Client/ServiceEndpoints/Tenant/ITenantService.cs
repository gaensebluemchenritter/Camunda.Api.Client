using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.Tenant
{
    public interface ITenantService
    {
        QueryResource<TenantQuery, TenantInfo> Query(TenantQuery query = null);
        Task Create(TenantInfo tenant);
    }
}