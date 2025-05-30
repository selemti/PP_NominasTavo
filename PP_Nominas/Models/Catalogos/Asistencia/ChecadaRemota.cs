using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia
{
    /// <summary>Registro de checada realizada remotamente por el empleado.</summary>
    public partial class ChecadaRemota : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private DateTime _fechaHora = DateTime.MinValue;
        private int _tipoEvento;
        private decimal _latitud;
        private decimal _longitud;
        private string _ubicacionId = string.Empty;
        private string _fotoAdjunta = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? name = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(name);
            return true;
        }

        [Display(Name = "ID de checada")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "ID del empleado")]
        public string EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        [Display(Name = "Fecha y hora")]
        public DateTime FechaHora
        {
            get => _fechaHora;
            set => SetProperty(ref _fechaHora, value);
        }

        [Display(Name = "Tipo de evento")]
        public int TipoEvento
        {
            get => _tipoEvento;
            set => SetProperty(ref _tipoEvento, value);
        }

        [Display(Name = "Latitud")]
        public decimal Latitud
        {
            get => _latitud;
            set => SetProperty(ref _latitud, value);
        }

        [Display(Name = "Longitud")]
        public decimal Longitud
        {
            get => _longitud;
            set => SetProperty(ref _longitud, value);
        }

        [Display(Name = "Ubicación registrada")]
        public string UbicacionId
        {
            get => _ubicacionId;
            set => SetProperty(ref _ubicacionId, value);
        }

        [Display(Name = "Foto adjunta")]
        public string FotoAdjunta
        {
            get => _fotoAdjunta;
            set => SetProperty(ref _fotoAdjunta, value);
        }

        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Usuario que modificó")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
