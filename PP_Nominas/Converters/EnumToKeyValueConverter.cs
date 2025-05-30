using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace PP_Nominas.Converters
{
    /// <summary>
    /// Convierte un Enum en una lista de KeyValuePair con su DisplayName para usarse en listas.
    /// ⚠ No usar este converter en Pickers con SelectedItem de tipo Enum (usar EnumHelper en el ViewModel).
    /// </summary>
    public class EnumToKeyValueConverter : IValueConverter
    {
        /// <inheritdoc/>
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null || !value.GetType().IsEnum)
                throw new InvalidCastException("EnumToKeyValueConverter solo puede aplicarse a valores enum individuales. No usar en listas de enums.");

            var enumType = value.GetType();
            return Enum.GetValues(enumType)
                       .Cast<Enum>()
                       .Select(e => new KeyValuePair<Enum, string>(e, GetDisplayName(e)))
                       .ToList();
        }

        /// <inheritdoc/>
        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is KeyValuePair<Enum, string> pair)
                return pair.Key;

            return Binding.DoNothing;
        }

        private string GetDisplayName(Enum enumValue)
        {
            return enumValue
                .GetType()
                .GetField(enumValue.ToString())?
                .GetCustomAttribute<DisplayAttribute>()?
                .GetName()
                ?? enumValue.ToString();
        }
    }
}
