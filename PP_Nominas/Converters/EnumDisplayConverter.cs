#nullable enable

using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using Microsoft.Maui.Controls;

namespace PP_Nominas.Converters
{
    /// <summary>
    /// Convierte un valor Enum a su nombre amigable usando [Display(Name="...")].
    /// </summary>
    public class EnumDisplayConverter : IValueConverter
    {
        /// <inheritdoc/>
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is Enum enumValue)
            {
                var display = enumValue
                    .GetType()
                    .GetField(enumValue.ToString())?
                    .GetCustomAttribute<DisplayAttribute>()?
                    .GetName();

                return display ?? enumValue.ToString();
            }

            return null;
        }

        /// <inheritdoc/>
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            // No soportado: conversión inversa no implementada
            return null;
        }
    }
}
