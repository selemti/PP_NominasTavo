using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace PP_Nominas.Models.Catalogos.Asistencia
{
    /// <summary>Horario asignado a un empleado.</summary>
    public class HorarioEmpleado : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private string _turnoId = string.Empty;
        private string? _plantillaHorarioId;
        private DateTime _fechaInicio = DateTime.MinValue;
        private DateTime? _fechaFin;
        private bool _vigente;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public string EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        public string TurnoId
        {
            get => _turnoId;
            set => SetProperty(ref _turnoId, value);
        }

        /// <summary>ID de la plantilla de horario.</summary>
        [Display(Name = "Plantilla de horario")]
        public string? HorarioPlantillaId
        {
            get => _plantillaHorarioId;
            set => SetProperty(ref _plantillaHorarioId, value);
        }

        /// <summary>Fecha de inicio del horario.</summary>
        [Display(Name = "Inicio")]
        public DateTime FechaInicio
        {
            get => _fechaInicio;
            set => SetProperty(ref _fechaInicio, value);
        }

        /// <summary>Fecha de fin del horario (opcional).</summary>
        [Display(Name = "Fin")]
        public DateTime? FechaFin
        {
            get => _fechaFin;
            set => SetProperty(ref _fechaFin, value);
        }

        public bool Vigente
        {
            get => _vigente;
            set => SetProperty(ref _vigente, value);
        }

        /// <summary>Fecha de la última modificación.</summary>
        [Display(Name = "Última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        /// <summary>Usuario que realizó la última modificación.</summary>
        [Display(Name = "Modificado por")]
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
