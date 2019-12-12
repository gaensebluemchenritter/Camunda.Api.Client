﻿namespace Camunda.Api.Client.Infrastructure
{
    internal class StringEnumConverter : Newtonsoft.Json.Converters.StringEnumConverter
    {
        public StringEnumConverter()
        {
            CamelCaseText = true;
            AllowIntegerValues = false; // integer values are not allowed because they dont't have API origin
        }
    }
}
