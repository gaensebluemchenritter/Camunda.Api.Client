using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Camunda.Api.Client.Infrastructure;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.Interfaces
{
    public interface IVariableResource
    {
        Task<Dictionary<string, VariableValue>> GetAll(bool deserializeValue = true);
        Task<VariableValue> Get(string variableName, bool deserializeValues = true);
        Task<HttpContent> GetBinary(string variableName);
        Task Set(string variableName, VariableValue variable);
        Task SetBinary(string variableName, BinaryDataContent data, BinaryVariableType valueType);
        Task Delete(string variableName);
        Task Modify(PatchVariables patch);
    }
}
