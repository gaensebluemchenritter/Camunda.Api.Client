using Refit;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ServiceEndpoints.Signal
{
    internal interface ISignalRestService
    {
        [Post("/signal")]
        Task ThrowSignal([Body] Signal signal);
    }
}