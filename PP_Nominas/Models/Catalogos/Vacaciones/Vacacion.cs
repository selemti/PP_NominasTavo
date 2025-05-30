using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Vacaciones
{
    /// <summary>Solicitud de vacaciones realizada por un empleado.</summary>
    public partial class Vacacion : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private DateTime? _fechaInicio;
        private DateTime? _fechaFin;
        private int? _diasProgramados;
        private int? _diasGozados;
        private string _periodoVacacionalId = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la solicitud de vacaciones")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Empleado solicitante")]
        public string EmpleadoId { get => _empleadoId; set => SetProperty(ref _empleadoId, value); }

        [Display(Name = "Fecha de inicio")]
        public DateTime? FechaInicio { get => _fechaInicio; set => SetProperty(ref _fechaInicio, value); }

        [Display(Name = "Fecha de fin")]
        public DateTime? FechaFin { get => _fechaFin; set => SetProperty(ref _fechaFin, value); }

        [Display(Name = "Días programados")]
        public int? DiasProgramados { get => _diasProgramados; set => SetProperty(ref _diasProgramados, value); }

        [Display(Name = "Días gozados")]
        public int? DiasGozados { get => _diasGozados; set => SetProperty(ref _diasGozados, value); }

        [Display(Name = "Periodo vacacional")]
        public string PeriodoVacacionalId { get => _periodoVacacionalId; set => SetProperty(ref _periodoVacacionalId, value); }

        [Display(Name = "Última modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Usuario que modificó")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
