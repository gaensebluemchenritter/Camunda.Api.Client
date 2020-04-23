#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.Resources
{
    public class CaseExecutionModifyVariables
    {
        /// <summary>
        /// contains variable key-value pairs. Each key is a variable name and each value a JSON variable value object.
        /// </summary>
        public Dictionary<string, VariableValue> Modifications = new Dictionary<string, VariableValue>();

        /// <summary>
        /// An array of String keys of variables to be deleted.
        /// </summary>
        public List<string> Deletions = new List<string>();
    }
}
