#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

#endregion

namespace Camunda.Api.Client.ServiceEndpoints.CaseExecution
{
    public class CaseExecutionVariableValueBinary
    {
        // TODO: check if object would suffice and how the serialization would work in that case! See VariableValue rawValue etc.
        /// <summary>
        /// The binary data to be set. application/octet-stream
        /// For File variables, this multipart can contain the filename, binary value and MIME type of the file variable to be set. Only the filename is mandatory.
        /// </summary>
        public byte[] Data { get; set; } = null;

        /// <summary>
        /// The name of the variable type. Either Bytes for a byte array variable or File for a file variable.
        /// </summary>
        public BinaryVariableType ValueType { get; set; }
    }
}
