using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using Camunda.Api.Client.Resources;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Infrastructure
{
        internal class VariableValueJsonConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(VariableValue));
            public override bool CanRead => true;
            public override bool CanWrite => false; // we are not handling serialization, use default converter

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                var target = (VariableValue)Activator.CreateInstance(objectType, true);
                object rawValue = null;

                while (reader.Read() && reader.TokenType != JsonToken.EndObject)
                {
                    if (reader.TokenType == JsonToken.PropertyName)
                    {
                        string property = (string)reader.Value;

                        // TODO KJ: check, if Variable.Value is indeed what gets used here, because that's what was used in the initial definition
                        if (property.Equals(nameof(existingValue), StringComparison.OrdinalIgnoreCase))
                        {
                            if (target.Type == VariableType.String)
                            {
                                // suppress JSON deserializer type guessing; string values read explicitly as string
                                rawValue = reader.ReadAsString();
                            }
                            else if (target.Type == VariableType.Date)
                            {
                                rawValue = reader.ReadAsDateTime();
                            }
                            else if (target.Type == VariableType.Bytes || target.Type == VariableType.File)
                            {
                                rawValue = Convert.FromBase64String(reader.ReadAsString() ?? "");
                            }
                            else
                            {
                                reader.Read();
                                rawValue = serializer.Deserialize(reader);
                            }
                        }
                        else if (PopulateMember(property, reader, serializer, target))
                        {
                            // property successfully filled
                        }
                        else
                        {
                            Debug.Assert(false, "Unknown JSON property: " + property);
                        }
                    }
                }

                target.rawValue = rawValue;

                return target;
            }

            protected virtual bool PopulateMember(string memberName, JsonReader reader, JsonSerializer serializer, object target)
            {
                BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy | BindingFlags.IgnoreCase;

                Type targetType = target.GetType();

                FieldInfo fieldInfo = targetType.GetField(memberName, bindingFlags);

                if (fieldInfo != null)
                {
                    reader.Read();
                    fieldInfo.SetValue(target, serializer.Deserialize(reader, fieldInfo.FieldType));
                    return true;
                }
                else 
                {
                    PropertyInfo propInfo = targetType.GetProperty(memberName, bindingFlags);
                    if (propInfo != null)
                    {
                        reader.Read();
                        propInfo.SetValue(target, serializer.Deserialize(reader, propInfo.PropertyType));
                        return true;
                    }
                }

                return false;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }

            private string StrToCamelCase(string str)
            {
                if (str?.Length > 1)
                    return str.Substring(0, 1).ToLower() + str.Substring(1);
                else
                    return str?.ToLower();
            }
        }
}
