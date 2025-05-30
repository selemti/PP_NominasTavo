using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Vacaciones
{
    /// <summary>Representa una solicitud de permiso.</summary>
    public partial class Permiso : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private int? _tipoPermiso;
        private DateTime? _fechaInicio;
        private DateTime? _fechaFin;
        private bool? _requiereSuplente;
        private int? _modalidadReposicion;
        private string _detalleReposicion = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la solicitud de permiso")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Empleado que solicita permiso")]
        public string EmpleadoId { get => _empleadoId; set => SetProperty(ref _empleadoId, value); }

        [Display(Name = "Tipo de permiso")]
        public int? TipoPermiso { get => _tipoPermiso; set => SetProperty(ref _tipoPermiso, value); }

        [Display(Name = "Fecha de inicio")]
        public DateTime? FechaInicio { get => _fechaInicio; set => SetProperty(ref _fechaInicio, value); }

        [Display(Name = "Fecha de fin")]
        public DateTime? FechaFin { get => _fechaFin; set => SetProperty(ref _fechaFin, value); }

        [Display(Name = "¿Requiere suplente?")]
        public bool? RequiereSuplente { get => _requiereSuplente; set => SetProperty(ref _requiereSuplente, value); }

        [Display(Name = "Modalidad de reposición")]
        public int? ModalidadReposicion { get => _modalidadReposicion; set => SetProperty(ref _modalidadReposicion, value); }

        [Display(Name = "Detalle de reposición")]
        public string DetalleReposicion { get => _detalleReposicion; set => SetProperty(ref _detalleReposicion, value); }

        [Display(Name = "Fecha de modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
