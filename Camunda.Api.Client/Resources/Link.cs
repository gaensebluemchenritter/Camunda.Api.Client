using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Resources
{
    public class Link
    {
        /// <summary>
        /// The HTTP method to use for the interaction.
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// The interaction URL.
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// The relation of the interaction (i.e., a symbolic name representing the nature of the interaction). Examples: create, delete ...
        /// </summary>
        public string Rel { get; set; }
    }
}
