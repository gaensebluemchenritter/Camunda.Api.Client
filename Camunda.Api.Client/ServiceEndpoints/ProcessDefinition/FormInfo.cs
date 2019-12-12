namespace Camunda.Api.Client.ServiceEndpoints.ProcessDefinition
{
    public class FormInfo
    {
        /// <summary>
        /// The form key for the process definition.
        /// </summary>
        public string Key;
        public string ContextPath;

        public override string ToString() => Key;
    }
}
