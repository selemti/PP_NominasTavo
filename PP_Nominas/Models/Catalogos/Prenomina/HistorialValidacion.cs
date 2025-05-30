using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Prenomina
{
    public partial class HistorialValidacion : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _periodoNominaId = string.Empty;
        private string _usuarioValidadorId = string.Empty;
        private string _resultado = string.Empty;
        private DateTime? _fechaValidacion;
        private string _observaciones = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de validación")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Periodo nómina")]
        public string PeriodoNominaId
        {
            get => _periodoNominaId;
            set => SetProperty(ref _periodoNominaId, value);
        }

        [Display(Name = "Usuario validador")]
        public string UsuarioValidadorId
        {
            get => _usuarioValidadorId;
            set => SetProperty(ref _usuarioValidadorId, value);
        }

        [Display(Name = "Resultado")]
        public string Resultado
        {
            get => _resultado;
            set => SetProperty(ref _resultado, value);
        }

        [Display(Name = "Fecha validación")]
        public DateTime? FechaValidacion
        {
            get => _fechaValidacion;
            set => SetProperty(ref _fechaValidacion, value);
        }

        [Display(Name = "Observaciones")]
        public string Observaciones
        {
            get => _observaciones;
            set => SetProperty(ref _observaciones, value);
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
