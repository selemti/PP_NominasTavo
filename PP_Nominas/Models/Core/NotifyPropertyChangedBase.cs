using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Core
{
    /// <summary>
    /// Clase base que implementa INotifyPropertyChanged para facilitar la notificación de cambios en propiedades.
    /// </summary>
    public abstract class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Llama al evento PropertyChanged con el nombre de la propiedad que cambió.
        /// </summary>
        /// <param name="propertyName">Nombre de la propiedad (se obtiene automáticamente si se omite).</param>
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Método auxiliar para establecer el valor de una propiedad y notificar el cambio sólo si es diferente.
        /// </summary>
        /// <typeparam name="T">Tipo de dato de la propiedad.</typeparam>
        /// <param name="field">Referencia al campo privado.</param>
        /// <param name="value">Nuevo valor a asignar.</param>
        /// <param name="propertyName">Nombre de la propiedad.</param>
        /// <returns>True si el valor cambió, false si es igual.</returns>
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
