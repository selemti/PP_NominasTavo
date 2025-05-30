using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Biometria
{
    /// <summary>
    /// Representa la clase LogsSincronizacion.
    /// </summary>
    public partial class LogsSincronizacion : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _dispositivoId = string.Empty;
        private DateTime? _fechaEvento;
        private string _descripcionLog = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del log de sincronización")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Dispositivo involucrado")]
        public string DispositivoId
        {
            get => _dispositivoId;
            set => SetProperty(ref _dispositivoId, value);
        }

        [Display(Name = "Fecha y hora del evento de sincronización")]
        public DateTime? FechaEvento
        {
            get => _fechaEvento;
            set => SetProperty(ref _fechaEvento, value);
        }

        [Display(Name = "Mensaje del evento")]
        public string DescripcionLog
        {
            get => _descripcionLog;
            set => SetProperty(ref _descripcionLog, value);
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
