using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Empleados
{
    public partial class ArchivoEmpleado : NotifyPropertyChangedBase
    {
        private string? _id;
        private string? _empleadoId;
        private int? _tipoArchivo;
        private string? _urlArchivo;
        private DateTime? _fechaCarga;
        private bool? _vigente;
        private DateTime _fechaUltimaModificacion;
        private string? _usuarioUltimaModificacion;

        [Display(Name = "ID del archivo")]
        public string? Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Empleado relacionado")]
        public string? EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        [Display(Name = "Tipo de documento (CURP, RFC, Foto, etc.)")]
        public int? TipoArchivo
        {
            get => _tipoArchivo;
            set => SetProperty(ref _tipoArchivo, value);
        }

        [Display(Name = "URL del archivo digitalizado")]
        public string? UrlArchivo
        {
            get => _urlArchivo;
            set => SetProperty(ref _urlArchivo, value);
        }

        [Display(Name = "Fecha de carga del archivo")]
        public DateTime? FechaCarga
        {
            get => _fechaCarga;
            set => SetProperty(ref _fechaCarga, value);
        }

        [Display(Name = "¿Archivo vigente?")]
        public bool? Vigente
        {
            get => _vigente;
            set => SetProperty(ref _vigente, value);
        }

        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Usuario que modificó el archivo")]
        public string? UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
