using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.CaseExecution
{
    internal interface ICaseExecutionRestService
    {
        [Get("/case-execution")]
        Task<List<CaseExecutionInfo>> GetList(QueryDictionary query, int? firstResult, int? maxResults);
        [Get("/case-execution/count")]
        Task<CountResult> GetListCount(QueryDictionary query);

        [Get("/case-execution/{id}")]
        Task<CaseExecutionInfo> Get(string id);

        [Post("/case-execution/{id}/manual-start")]
        Task StartExecution(string id, [Body]CaseExecutionStart start);

        [Post("/case-execution/{id}/complete")]
        Task CompleteExecution(string id, [Body]CaseExecutionComplete complete);

        [Post("/case-execution/{id}/disable")]
        Task DisableExecution(string id, [Body]CaseExecutionDisable disable);

        [Post("/case-execution/{id}/reenable")]
        Task ReEnableExecution(string id, [Body]CaseExecutionReEnable reenable);

        [Post("/case-execution/{id}/terminate")]
        Task TerminateExecution(string id, [Body]CaseExecutionTerminate terminate);

        // local variables:

        [Get("/case-execution/{id}/localVariables/{varName}")]
        Task<VariableValue> GetLocalVariable(string id, string varName, bool deserializeValues = true);

        [Get("/case-execution/{id}/localVariables/{varName}/data")]
        Task<HttpResponseMessage> GetLocalVariableBinary(string id, string varName);

        [Get("/case-execution/{id}/localVariables")]
        Task<Dictionary<string, VariableValue>> GetLocalVariables(string id, bool deserializeValues = true);

        [Put("/case-execution/{id}/localVariables/{varName}")]
        Task UpdateLocalVariable(string id, string varName, [Body] VariableValue variableValue);

        [Put("/case-execution/{id}/localVariables/{varName}/data")]
        Task UpdateLocalVariableBinary(string id, string varName, [Body] CaseExecutionVariableValueBinary value);

        [Post("/case-execution/{id}/localVariables")]
        Task ModifyLocalVariables(string id, [Body] CaseExecutionModifyVariables modifyVariables);

        [Delete("/case-execution/{id}/localVariables/{varName}")]
        Task DeleteLocalVariable(string id, string varName);

        // process wide variables: TODO
    }
}