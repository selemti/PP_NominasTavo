using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia
{
    public partial class Incidencia : INotifyPropertyChanged
    {
        private int? _tipoFalta;
        private string _checadaId = string.Empty;
        private string _estatusIncidencia = string.Empty;
        private double? _duracionRetardo;
        private string _justificacion = string.Empty;
        private string _tipoPermiso = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "Tipo de Incidencia")]
        public int? TipoFalta
        {
            get => _tipoFalta;
            set => SetProperty(ref _tipoFalta, value);
        }

        [Display(Name = "ID de la Checada asociada")]
        public string ChecadaId
        {
            get => _checadaId;
            set => SetProperty(ref _checadaId, value);
        }

        [Display(Name = "Estatus de la Incidencia")]
        public string EstatusIncidencia
        {
            get => _estatusIncidencia;
            set => SetProperty(ref _estatusIncidencia, value);
        }

        [Display(Name = "Duración del Retardo (en horas)")]
        public double? DuracionRetardo
        {
            get => _duracionRetardo;
            set => SetProperty(ref _duracionRetardo, value);
        }

        [Display(Name = "Justificación de la Incidencia")]
        public string Justificacion
        {
            get => _justificacion;
            set => SetProperty(ref _justificacion, value);
        }

        [Display(Name = "Tipo de Permiso")]
        public string TipoPermiso
        {
            get => _tipoPermiso;
            set => SetProperty(ref _tipoPermiso, value);
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
