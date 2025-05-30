using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase Justificante.
    /// </summary>
    public partial class Justificante : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private int? _tipoJustificante;
        private string _urlDocumento = string.Empty;
        private DateTime? _fechaEmision;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        /// <summary>
        /// ID del justificante de incidencia
        /// </summary>
        [Display(Name = "ID del justificante de incidencia")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        /// <summary>
        /// Tipo de documento (certificado médico, etc.)
        /// </summary>
        [Display(Name = "Tipo de documento (certificado médico, etc.)")]
        public int? TipoJustificante
        {
            get => _tipoJustificante;
            set => SetProperty(ref _tipoJustificante, value);
        }

        /// <summary>
        /// URL del archivo digital
        /// </summary>
        [Display(Name = "URL del archivo digital")]
        public string UrlDocumento
        {
            get => _urlDocumento;
            set => SetProperty(ref _urlDocumento, value);
        }

        /// <summary>
        /// Fecha de emisión del justificante
        /// </summary>
        [Display(Name = "Fecha de emisión del justificante")]
        public DateTime? FechaEmision
        {
            get => _fechaEmision;
            set => SetProperty(ref _fechaEmision, value);
        }

        /// <summary>
        /// Fecha de última modificación
        /// </summary>
        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        /// <summary>
        /// Usuario que realizó la última modificación
        /// </summary>
        [Display(Name = "Usuario que realizó la última modificación")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
