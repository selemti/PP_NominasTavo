using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase RangoTolerancia.
    /// </summary>
    public partial class RangoTolerancia : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _codigo = string.Empty;
        private string _nombre = string.Empty;
        private int? _minutosDesde;
        private int? _minutosHasta;
        private bool? _penalizacion;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del rango")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Código del rango")]
        public string Codigo
        {
            get => _codigo;
            set => SetProperty(ref _codigo, value);
        }

        [Display(Name = "Nombre descriptivo")]
        public string Nombre
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }

        [Display(Name = "Minutos desde que inicia el rango")]
        public int? MinutosDesde
        {
            get => _minutosDesde;
            set => SetProperty(ref _minutosDesde, value);
        }

        [Display(Name = "Minutos hasta donde termina el rango")]
        public int? MinutosHasta
        {
            get => _minutosHasta;
            set => SetProperty(ref _minutosHasta, value);
        }

        [Display(Name = "¿Aplica descuento? (true/false)")]
        public bool? Penalizacion
        {
            get => _penalizacion;
            set => SetProperty(ref _penalizacion, value);
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
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
