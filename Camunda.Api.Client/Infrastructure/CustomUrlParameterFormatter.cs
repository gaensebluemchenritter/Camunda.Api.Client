using System;
using System.Globalization;
using System.Reflection;
using Refit;

namespace Camunda.Api.Client.Infrastructure
{
    internal class CustomUrlParameterFormatter : DefaultUrlParameterFormatter
    {
        public override string Format(object parameterValue, ICustomAttributeProvider attributeProvider, Type type)
        {
            if (parameterValue is bool)
                return string.Format(CultureInfo.InvariantCulture, "{0}", parameterValue).ToLowerInvariant();

            return base.Format(parameterValue, attributeProvider, type);
        }
    }
}
