 #region Usings

 using System.Net.Http;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.DecisionRequirementsDefinition
{
    public abstract class DecisionRequirementsDefinitionResource
    {
        /// <summary>
        /// Retrieves a single decision requirements definition
        /// </summary>
        /// <returns></returns>
        public abstract Task<DecisionRequirementsDefinitionInfo> Get();

        /// <summary>
        /// Retrieves the DMN XML of this decision requirements definition.
        /// </summary>
        public abstract Task<DecisionRequirementsDefinitionDiagram> GetXml();

        /// <summary>
        /// Retrieves the diagram of a decision requirements definition.
        /// </summary>
        public abstract Task<HttpResponseMessage> GetDiagram();
    }
}
