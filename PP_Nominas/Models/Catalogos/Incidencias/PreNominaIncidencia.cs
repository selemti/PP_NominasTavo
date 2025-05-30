// Modelo: PreNominaIncidencia.cs
using PP_Nominas.Models.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Incidencias
{
    public partial class PreNominaIncidencia : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private string _periodoNominaId = string.Empty;
        private string _tipoIncidenciaId = string.Empty;
        private DateTime? _fecha;
        private decimal? _duracion;
        private string _justificanteAdjunto = string.Empty;
        private string _estatus = string.Empty;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la incidencia ObjectId")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Empleado afectado")]
        public string EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        [Display(Name = "Periodo en que se aplicará la incidencia")]
        public string PeriodoNominaId
        {
            get => _periodoNominaId;
            set => SetProperty(ref _periodoNominaId, value);
        }

        [Display(Name = "Tipo de incidencia aplicada")]
        public string TipoIncidenciaId
        {
            get => _tipoIncidenciaId;
            set => SetProperty(ref _tipoIncidenciaId, value);
        }

        [Display(Name = "Fecha en que se aplica")]
        public DateTime? Fecha
        {
            get => _fecha;
            set => SetProperty(ref _fecha, value);
        }

        [Display(Name = "Duración en horas o días")]
        public decimal? Duracion
        {
            get => _duracion;
            set => SetProperty(ref _duracion, value);
        }

        [Display(Name = "URL del documento (si aplica)")]
        public string JustificanteAdjunto
        {
            get => _justificanteAdjunto;
            set => SetProperty(ref _justificanteAdjunto, value);
        }

        [Display(Name = "Aprobada, Pendiente, Rechazada")]
        public string Estatus
        {
            get => _estatus;
            set => SetProperty(ref _estatus, value);
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
