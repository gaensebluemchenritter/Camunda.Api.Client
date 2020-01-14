using System.Threading.Tasks;

namespace Camunda.Api.Client.ServiceEndpoints.Signal
{
    public interface ISignalService
    {
        /// <summary>
        /// A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers.
        /// Internally this maps to the engine’s signal event received builder method RuntimeService#createSignalEvent().
        /// </summary>
        Task ThrowSignal(Signal signal);
    }
}