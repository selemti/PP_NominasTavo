using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia
{
    /// <summary>Representa un turno laboral asignable.</summary>
    public partial class Turno : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _nombreTurno = string.Empty;
        private string _horaEntrada = string.Empty;
        private string _horaSalida = string.Empty;
        private int? _tipoTurno;
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

        [Display(Name = "ID único del turno")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Nombre del turno")]
        public string NombreTurno
        {
            get => _nombreTurno;
            set => SetProperty(ref _nombreTurno, value);
        }

        [Display(Name = "Hora de entrada")]
        public string HoraEntrada
        {
            get => _horaEntrada;
            set => SetProperty(ref _horaEntrada, value);
        }

        [Display(Name = "Hora de salida")]
        public string HoraSalida
        {
            get => _horaSalida;
            set => SetProperty(ref _horaSalida, value);
        }

        [Display(Name = "Tipo de turno")]
        public int? TipoTurno
        {
            get => _tipoTurno;
            set => SetProperty(ref _tipoTurno, value);
        }

        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
