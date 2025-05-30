// Modelo
using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Fiscal
{
    public partial class TablaInfonavit : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private int? _tipoDescuento;
        private decimal? _valorDescuento;
        private string _descripcion = string.Empty;
        private int? _ejercicioFiscal;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de tabla de Infonavit")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Tipo (0 = Factor Salario, 1 = Cuota Fija)")]
        public int? TipoDescuento
        {
            get => _tipoDescuento;
            set => SetProperty(ref _tipoDescuento, value);
        }

        [Display(Name = "Valor aplicable del descuento")]
        public decimal? ValorDescuento
        {
            get => _valorDescuento;
            set => SetProperty(ref _valorDescuento, value);
        }

        [Display(Name = "Descripción adicional")]
        public string Descripcion
        {
            get => _descripcion;
            set => SetProperty(ref _descripcion, value);
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
