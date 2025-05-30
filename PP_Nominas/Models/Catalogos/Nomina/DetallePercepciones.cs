using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Nomina
{
    public partial class DetallePercepciones : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _reciboNominaId = string.Empty;
        private string _tipoCompensacionId = string.Empty;
        private decimal? _monto;
        private int? _tipoFiscalizacion;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del detalle de percepción")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Recibo de nómina asociado")]
        public string ReciboNominaId
        {
            get => _reciboNominaId;
            set => SetProperty(ref _reciboNominaId, value);
        }

        [Display(Name = "Concepto de percepción aplicada")]
        public string TipoCompensacionId
        {
            get => _tipoCompensacionId;
            set => SetProperty(ref _tipoCompensacionId, value);
        }

        [Display(Name = "Monto de la percepción")]
        public decimal? Monto
        {
            get => _monto;
            set => SetProperty(ref _monto, value);
        }

        [Display(Name = "(0 = Gravado, 1 = Exento, 2 = Excedente)")]
        public int? TipoFiscalizacion
        {
            get => _tipoFiscalizacion;
            set => SetProperty(ref _tipoFiscalizacion, value);
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