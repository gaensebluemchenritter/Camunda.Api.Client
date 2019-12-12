using System;
using System.Globalization;
using Camunda.Api.Client.Extensions;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Infrastructure
{
    internal class CustomIsoDateTimeConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public CustomIsoDateTimeConverter()
        {
            Culture = CultureInfo.InvariantCulture;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is DateTime dateTime)
            {
                if ((DateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                    || (DateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
                {
                    dateTime = dateTime.ToUniversalTime();
                }

                writer.WriteValue(dateTime.ToJavaISO8601());
            }
            else
            {
                base.WriteJson(writer, value, serializer);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool nullable = objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>);

            if (reader.TokenType == JsonToken.String)
            {
                string dateText = reader.Value.ToString();

                if (string.IsNullOrEmpty(dateText) && nullable)
                    return null;

                if (dateText.EndsWith("UTC"))
                {
                    if (DateTime.TryParseExact(dateText.Replace("UTC", "Z"), "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFK", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out var dt))
                        return dt;
                }
            }

            return base.ReadJson(reader, objectType, existingValue, serializer);
        }
    }
}
