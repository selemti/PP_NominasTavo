using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase CompensacionOvertime.
    /// </summary>
    public partial class CompensacionOvertime : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _codigo = string.Empty;
        private string _nombre = string.Empty;
        private string _descripcion = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        [Display(Name = "ID del tipo de compensación")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        /// <summary>
        /// Obtiene o establece Codigo.
        /// </summary>
        [Display(Name = "Código corto de compensación")]
        public string Codigo
        {
            get => _codigo;
            set => SetProperty(ref _codigo, value);
        }

        /// <summary>
        /// Obtiene o establece Nombre.
        /// </summary>
        [Display(Name = "Nombre del tipo de compensación")]
        public string Nombre
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }

        /// <summary>
        /// Obtiene o establece Descripcion.
        /// </summary>
        [Display(Name = "Descripción detallada")]
        public string Descripcion
        {
            get => _descripcion;
            set => SetProperty(ref _descripcion, value);
        }

        /// <summary>
        /// Fecha de la última modificación del documento.
        /// </summary>
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        /// <summary>
        /// Identificador del usuario que realizó la última modificación.
        /// </summary>
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
