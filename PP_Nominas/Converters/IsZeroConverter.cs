using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace PP_Nominas.Converters
{
    public class IsZeroConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
            => (value is int count && count == 0);

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
            => throw new NotImplementedException();

    }
}
