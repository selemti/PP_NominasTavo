using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Seguridad
{
    /// <summary>Perfil de permisos asignado a usuarios.</summary>
    public partial class Perfil : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _nombrePerfil = string.Empty;
        private string _descripcionPerfil = string.Empty;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del perfil")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Nombre del perfil")]
        public string NombrePerfil
        {
            get => _nombrePerfil;
            set => SetProperty(ref _nombrePerfil, value);
        }

        [Display(Name = "Descripción funcional")]
        public string DescripcionPerfil
        {
            get => _descripcionPerfil;
            set => SetProperty(ref _descripcionPerfil, value);
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
