using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Vacaciones
{
    /// <summary>Representa el periodo anual de vacaciones asignado a un empleado.</summary>
    public partial class PeriodoVacacional : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private int? _anio;
        private int? _diasAsignados;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del periodo vacacional")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Año")]
        public int? Anio { get => _anio; set => SetProperty(ref _anio, value); }

        [Display(Name = "Días asignados")]
        public int? DiasAsignados { get => _diasAsignados; set => SetProperty(ref _diasAsignados, value); }

        [Display(Name = "Fecha de modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Usuario que modificó")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
