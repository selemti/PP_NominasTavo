using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Prenomina
{
    /// <summary>Tipo de periodo definido para el calendario de nómina (quincenal, semanal, etc.).</summary>
    public partial class TipoPeriodo : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _nombreTipoPeriodo = string.Empty;
        private int _diasPeriodo;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del tipo de periodo")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Nombre del periodo")]
        public string NombreTipoPeriodo
        {
            get => _nombreTipoPeriodo;
            set => SetProperty(ref _nombreTipoPeriodo, value);
        }

        [Display(Name = "Número de días")]
        public int DiasPeriodo
        {
            get => _diasPeriodo;
            set => SetProperty(ref _diasPeriodo, value);
        }

        [Display(Name = "Última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
