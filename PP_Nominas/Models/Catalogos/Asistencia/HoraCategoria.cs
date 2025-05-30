using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase HoraCategoria.
    /// </summary>
    public partial class HoraCategoria : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _codigo = string.Empty;
        private string _nombre = string.Empty;
        private string _descripcion = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la categoría")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Código de categoría")]
        public string Codigo
        {
            get => _codigo;
            set => SetProperty(ref _codigo, value);
        }

        [Display(Name = "Nombre legible de categoría")]
        public string Nombre
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }

        [Display(Name = "Descripción extendida")]
        public string Descripcion
        {
            get => _descripcion;
            set => SetProperty(ref _descripcion, value);
        }

        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value)) return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
