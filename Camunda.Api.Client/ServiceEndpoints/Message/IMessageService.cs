using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ServiceEndpoints.Message
{
    public interface IMessageService
    {
        /// <summary>
        /// Deliver a message to the process engine to either trigger a message start event or an intermediate message catching event. 
        /// Internally this maps to the engine’s message correlation builder methods <c>MessageCorrelationBuilder#correlate()</c> and <c>MessageCorrelationBuilder#correlateAll()</c>
        /// </summary>
        Task<List<CorrelationResult>> DeliverMessage(CorrelationMessage message);
    }
}