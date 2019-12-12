namespace Camunda.Api.Client.Resources
{
    public class SuspensionState
    {
        public bool Suspended;

        public override string ToString() => Suspended.ToString();
    }
}
