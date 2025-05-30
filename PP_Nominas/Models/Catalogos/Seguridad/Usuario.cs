using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Seguridad
{
    /// <summary>Usuario registrado en el sistema.</summary>
    public partial class Usuario : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _nombreUsuario = string.Empty;
        private string _correoElectronico = string.Empty;
        private string _perfilId = string.Empty;
        private int? _estatusUsuario;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del usuario")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Nombre de login")]
        public string NombreUsuario
        {
            get => _nombreUsuario;
            set => SetProperty(ref _nombreUsuario, value);
        }

        [Display(Name = "Correo corporativo")]
        public string CorreoElectronico
        {
            get => _correoElectronico;
            set => SetProperty(ref _correoElectronico, value);
        }

        [Display(Name = "Perfil asignado")]
        public string PerfilId
        {
            get => _perfilId;
            set => SetProperty(ref _perfilId, value);
        }

        [Display(Name = "Estatus del usuario")]
        public int? EstatusUsuario
        {
            get => _estatusUsuario;
            set => SetProperty(ref _estatusUsuario, value);
        }

        [Display(Name = "Fecha de modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Usuario de modificación")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
