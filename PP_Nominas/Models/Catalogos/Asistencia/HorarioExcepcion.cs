using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase HorarioExcepcion.
    /// </summary>
    public partial class HorarioExcepcion : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private DateTime? _fechaInicio;
        private DateTime? _fechaFin;
        private string _turnoEspecialId = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        [Display(Name = "ID de la excepción")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        [Display(Name = "Empleado asociado")]
        public string EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        /// <summary>
        /// Obtiene o establece FechaInicio.
        /// </summary>
        [Display(Name = "Inicio de excepción")]
        public DateTime? FechaInicio
        {
            get => _fechaInicio;
            set => SetProperty(ref _fechaInicio, value);
        }

        /// <summary>
        /// Obtiene o establece FechaFin.
        /// </summary>
        [Display(Name = "Fin de excepción")]
        public DateTime? FechaFin
        {
            get => _fechaFin;
            set => SetProperty(ref _fechaFin, value);
        }

        /// <summary>
        /// Obtiene o establece TurnoEspecialId.
        /// </summary>
        [Display(Name = "Turno alterno aplicado")]
        public string TurnoEspecialId
        {
            get => _turnoEspecialId;
            set => SetProperty(ref _turnoEspecialId, value);
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

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? name = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(name);
            return true;
        }
    }
}
