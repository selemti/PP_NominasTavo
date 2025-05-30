// Modelo
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Fiscal
{
    public partial class TablaIsr : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private decimal? _limiteInferior;
        private decimal? _limiteSuperior;
        private decimal? _cuotaFija;
        private decimal? _porcentajeExcedente;
        private int? _periodo;
        private int? _ejercicioFiscal;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del rango de ISR")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Límite inferior del rango")]
        public decimal? LimiteInferior
        {
            get => _limiteInferior;
            set => SetProperty(ref _limiteInferior, value);
        }

        [Display(Name = "Límite superior del rango")]
        public decimal? LimiteSuperior
        {
            get => _limiteSuperior;
            set => SetProperty(ref _limiteSuperior, value);
        }

        [Display(Name = "Cuota fija aplicable")]
        public decimal? CuotaFija
        {
            get => _cuotaFija;
            set => SetProperty(ref _cuotaFija, value);
        }

        [Display(Name = "Porcentaje aplicable al excedente")]
        public decimal? PorcentajeExcedente
        {
            get => _porcentajeExcedente;
            set => SetProperty(ref _porcentajeExcedente, value);
        }

        [Display(Name = "Periodo aplicable (0 = Diario, 1 = Semanal, 2 = Quincenal, 3 = Mensual)")]
        public int? Periodo
        {
            get => _periodo;
            set => SetProperty(ref _periodo, value);
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
