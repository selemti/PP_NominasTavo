// Modelo
using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Fiscal
{
    public partial class TablaImss : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _concepto = string.Empty;
        private decimal? _porcentajePatronal;
        private decimal? _porcentajeObrero;
        private bool? _salarioMinimoAplica;
        private int? _ejercicioFiscal;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la cuota IMSS")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Concepto de cuota (ej. Enfermedad y Maternidad)")]
        public string Concepto
        {
            get => _concepto;
            set => SetProperty(ref _concepto, value);
        }

        [Display(Name = "Porcentaje de aportación patronal")]
        public decimal? PorcentajePatronal
        {
            get => _porcentajePatronal;
            set => SetProperty(ref _porcentajePatronal, value);
        }

        [Display(Name = "Porcentaje de aportación del trabajador")]
        public decimal? PorcentajeObrero
        {
            get => _porcentajeObrero;
            set => SetProperty(ref _porcentajeObrero, value);
        }

        [Display(Name = "Si aplica solo a salario mínimo (bool)")]
        public bool? SalarioMinimoAplica
        {
            get => _salarioMinimoAplica;
            set => SetProperty(ref _salarioMinimoAplica, value);
        }

        [Display(Name = "Año fiscal aplicable")]
        public int? EjercicioFiscal
        {
            get => _ejercicioFiscal;
            set => SetProperty(ref _ejercicioFiscal, value);
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
    }
}
