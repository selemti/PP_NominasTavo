using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Shared
{
    /// <summary>Catálogo base de entidades polimórficas o asociadas a flujos dinámicos.</summary>
    public partial class CatalogoEntidades : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _entityCode = string.Empty;
        private string _nombreEntidad = string.Empty;
        private string _moduloRelacionado = string.Empty;
        private string _descripcionEntidad = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID único de la entidad")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Código de la entidad")]
        public string EntityCode { get => _entityCode; set => SetProperty(ref _entityCode, value); }

        [Display(Name = "Nombre descriptivo")]
        public string NombreEntidad { get => _nombreEntidad; set => SetProperty(ref _nombreEntidad, value); }

        [Display(Name = "Módulo relacionado")]
        public string ModuloRelacionado { get => _moduloRelacionado; set => SetProperty(ref _moduloRelacionado, value); }

        [Display(Name = "Descripción funcional")]
        public string DescripcionEntidad { get => _descripcionEntidad; set => SetProperty(ref _descripcionEntidad, value); }

        [Display(Name = "Fecha última modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Usuario que modificó")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
