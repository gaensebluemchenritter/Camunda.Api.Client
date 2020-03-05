#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.DecisionRequirementsDefinition
{
    public class DecisionRequirementsDefinitionDiagram
    {
        /// <summary>
        /// The id of the decision requirements definition.
        /// </summary>
        public string Id;

        /// <summary>
        /// An escaped XML string containing the XML that this decision requirements definition was deployed with. Carriage returns, line feeds and quotation marks are escaped.
        /// </summary>
        public string DmnXml;

        public override string ToString() => Id;
    }
}
