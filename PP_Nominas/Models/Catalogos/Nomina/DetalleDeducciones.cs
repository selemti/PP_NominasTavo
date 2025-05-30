using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Nomina
{
    public partial class DetalleDeducciones : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _reciboNominaId = string.Empty;
        private string _tipoDeduccionId = string.Empty;
        private decimal? _monto;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del detalle de deducción")]
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

        [Display(Name = "Concepto de deducción aplicada")]
        public string TipoDeduccionId
        {
            get => _tipoDeduccionId;
            set => SetProperty(ref _tipoDeduccionId, value);
        }

        [Display(Name = "Monto de la deducción")]
        public decimal? Monto
        {
            get => _monto;
            set => SetProperty(ref _monto, value);
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