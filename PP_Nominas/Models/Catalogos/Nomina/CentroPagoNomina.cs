using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Nomina
{
    public partial class CentroPagoNomina : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _nombreCentroPago = string.Empty;
        private int? _fechaCorteQuincena1;
        private int? _fechaCorteQuincena2;
        private int? _fechaPagoQuincena1;
        private int? _fechaPagoQuincena2;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del centro de pago")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Nombre del centro de pago")]
        public string NombreCentroPago
        {
            get => _nombreCentroPago;
            set => SetProperty(ref _nombreCentroPago, value);
        }

        [Display(Name = "Fecha de corte quincena 1")]
        public int? FechaCorteQuincena1
        {
            get => _fechaCorteQuincena1;
            set => SetProperty(ref _fechaCorteQuincena1, value);
        }

        [Display(Name = "Fecha de corte quincena 2")]
        public int? FechaCorteQuincena2
        {
            get => _fechaCorteQuincena2;
            set => SetProperty(ref _fechaCorteQuincena2, value);
        }

        [Display(Name = "Fecha de pago quincena 1")]
        public int? FechaPagoQuincena1
        {
            get => _fechaPagoQuincena1;
            set => SetProperty(ref _fechaPagoQuincena1, value);
        }

        [Display(Name = "Fecha de pago quincena 2")]
        public int? FechaPagoQuincena2
        {
            get => _fechaPagoQuincena2;
            set => SetProperty(ref _fechaPagoQuincena2, value);
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
