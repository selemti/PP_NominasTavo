using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Shared
{
    /// <summary>Persona de contacto relacionada a una entidad (p. ej. emergencia o referencia).</summary>
    public partial class Contacto : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _tipoEntidad = string.Empty;
        private string _entidadId = string.Empty;
        private string _nombreContacto = string.Empty;
        private string _telefonoContacto = string.Empty;
        private string _parentesco = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del contacto")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Tipo de entidad")]
        public string TipoEntidad { get => _tipoEntidad; set => SetProperty(ref _tipoEntidad, value); }

        [Display(Name = "ID de entidad asociada")]
        public string EntidadId { get => _entidadId; set => SetProperty(ref _entidadId, value); }

        [Display(Name = "Nombre del contacto")]
        public string NombreContacto { get => _nombreContacto; set => SetProperty(ref _nombreContacto, value); }

        [Display(Name = "Teléfono")]
        public string TelefonoContacto { get => _telefonoContacto; set => SetProperty(ref _telefonoContacto, value); }

        [Display(Name = "Parentesco o relación")]
        public string Parentesco { get => _parentesco; set => SetProperty(ref _parentesco, value); }

        [Display(Name = "Fecha de modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Usuario que modificó")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
