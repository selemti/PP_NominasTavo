using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace PP_Nominas.Converters
{
    public class StringNotEmptyConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string str)
                return !string.IsNullOrWhiteSpace(str);

            return false;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            // Generalmente no se usa ConvertBack para este converter
            return null;
        }
    }
}
