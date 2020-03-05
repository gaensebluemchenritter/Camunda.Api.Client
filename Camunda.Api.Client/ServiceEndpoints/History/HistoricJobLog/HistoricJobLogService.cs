using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.ServiceEndpoints.History.HistoricJobLog
{
    public class HistoricJobLogService
    {
        private IHistoricJobLogRestService _api;

        internal HistoricJobLogService(IHistoricJobLogRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricJobLogQuery, HistoricJobLog> Query(HistoricJobLogQuery query = null) =>
            new QueryResource<HistoricJobLogQuery, HistoricJobLog>(
                query, 
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));

        /// <param name="historicJobLogId">The id of the log entry.</param>
        public HistoricJobLogResource this[string historicJobLogId] => new HistoricJobLogResource(_api, historicJobLogId);
    }
}
