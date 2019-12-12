using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Camunda.Api.Client.Resources;

namespace Camunda.Api.Client.Infrastructure
{
    public class VariableValueTypeConverter : System.ComponentModel.TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return true;
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return true;
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            VariableValue vv = (VariableValue)value;
            return vv.GetValue(destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            return VariableValue.FromObject(value);
        }
    }
}
