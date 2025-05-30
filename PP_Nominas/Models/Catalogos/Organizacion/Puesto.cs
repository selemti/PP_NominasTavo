using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Organizacion
{
    public partial class Puesto : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private int? _nivelPuesto;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del puesto")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Nivel del puesto")]
        public int? NivelPuesto { get => _nivelPuesto; set => SetProperty(ref _nivelPuesto, value); }

        [Display(Name = "Fecha modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
