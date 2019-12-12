namespace Camunda.Api.Client.Resources
{
    /// https://docs.camunda.org/manual/7.9/user-guide/process-engine/variables/#supported-variable-values
    public enum VariableType
    {
        Boolean,
        Bytes,
        Short,
        Integer,
        Long,
        Double,
        Date,
        String,
        Number,

        Null,

        File,
        Object,

        Json,
        Xml
    }
}
