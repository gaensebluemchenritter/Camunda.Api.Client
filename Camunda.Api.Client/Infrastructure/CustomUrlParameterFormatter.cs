using System.Globalization;
using System.Reflection;
using Refit;

namespace Camunda.Api.Client.Infrastructure
{
    internal class CustomUrlParameterFormatter : DefaultUrlParameterFormatter
    {
        public override string Format(object parameterValue, ParameterInfo parameterInfo)
        {
            if (parameterValue is bool)
                return string.Format(CultureInfo.InvariantCulture, "{0}", parameterValue).ToLower();
            else
                return base.Format(parameterValue, parameterInfo);
        }
    }
}
