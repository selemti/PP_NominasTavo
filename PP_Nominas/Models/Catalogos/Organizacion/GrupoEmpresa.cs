using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Organizacion
{
    public partial class GrupoEmpresa : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _clave = string.Empty;
        private string _nombre = string.Empty;
        private string _rfc = string.Empty;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del grupo empresarial")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Clave")]
        public string Clave { get => _clave; set => SetProperty(ref _clave, value); }

        [Display(Name = "Nombre")]
        public string Nombre { get => _nombre; set => SetProperty(ref _nombre, value); }

        [Display(Name = "RFC")]
        public string Rfc { get => _rfc; set => SetProperty(ref _rfc, value); }

        [Display(Name = "Fecha modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
