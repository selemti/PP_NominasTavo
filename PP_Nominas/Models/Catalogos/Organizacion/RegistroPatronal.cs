using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Organizacion
{
    public partial class RegistroPatronal : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _rfc = string.Empty;
        private string _numeroRegistro = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del registro patronal")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "RFC del patrón")]
        public string Rfc { get => _rfc; set => SetProperty(ref _rfc, value); }

        [Display(Name = "Número de registro IMSS")]
        public string NumeroRegistro { get => _numeroRegistro; set => SetProperty(ref _numeroRegistro, value); }

        [Display(Name = "Fecha de modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
