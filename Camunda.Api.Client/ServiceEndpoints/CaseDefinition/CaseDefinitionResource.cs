using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ServiceEndpoints.CaseDefinition
{
    public abstract class CaseDefinitionResource
    {
        /// <summary>
        /// Retrieves a case definition according to the CaseDefinition interface in the engine.
        /// </summary>
        public abstract Task<CaseDefinitionInfo> Get();

        /// <summary>
        /// Retrieves the CMMN XML of a case definition.
        /// </summary>
        public abstract Task<CaseDefinitionDiagram> GetXml();

        /// <summary>
        /// Retrieves the diagram of a case definition.
        /// </summary>
        /// <returns></returns>
        public abstract Task<HttpContent> GetDiagram();

        /// <summary>
        /// Instantiates a given case definition. Case variables and business key may be supplied in the request body.
        /// </summary>
        public abstract Task<CaseInstanceInfo> CreateCaseInstance(CreateCaseInstance parameters);

        /// <summary>
        /// Updates history time to live for case definition with given id. The field is used within History cleanup.
        /// </summary>
        /// <param name="historyTimeToLive"></param>
        /// <returns></returns>
        public abstract Task UpdateHistoryTimeToLive(CaseDefinitionHistoryTimeToLive historyTimeToLive);
    }
}