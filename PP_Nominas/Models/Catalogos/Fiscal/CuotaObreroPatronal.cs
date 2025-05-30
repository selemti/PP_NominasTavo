using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Fiscal
{
    public partial class CuotaObreroPatronal : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _concepto = string.Empty;
        private decimal? _porcentajePatron;
        private decimal? _porcentajeEmpleado;
        private DateTime? _vigenciaInicio;
        private DateTime? _vigenciaFin;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la cuota")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Concepto (Ej: Enfermedad, Retiro)")]
        public string Concepto
        {
            get => _concepto;
            set => SetProperty(ref _concepto, value);
        }

        [Display(Name = "% Aportación patronal (actualizable)")]
        public decimal? PorcentajePatron
        {
            get => _porcentajePatron;
            set => SetProperty(ref _porcentajePatron, value);
        }

        [Display(Name = "% Aportación empleado")]
        public decimal? PorcentajeEmpleado
        {
            get => _porcentajeEmpleado;
            set => SetProperty(ref _porcentajeEmpleado, value);
        }

        [Display(Name = "Fecha de inicio de vigencia")]
        public DateTime? VigenciaInicio
        {
            get => _vigenciaInicio;
            set => SetProperty(ref _vigenciaInicio, value);
        }

        [Display(Name = "Fecha de fin de vigencia")]
        public DateTime? VigenciaFin
        {
            get => _vigenciaFin;
            set => SetProperty(ref _vigenciaFin, value);
        }

        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Usuario de última modificación")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
