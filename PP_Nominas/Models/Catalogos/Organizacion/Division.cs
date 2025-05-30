using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Organizacion
{
    public partial class Division : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _grupoEmpresaId = string.Empty;
        private string _claveDivision = string.Empty;
        private string _nombreDivision = string.Empty;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la división")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Grupo empresarial")]
        public string GrupoEmpresaId { get => _grupoEmpresaId; set => SetProperty(ref _grupoEmpresaId, value); }

        [Display(Name = "Clave de división")]
        public string ClaveDivision { get => _claveDivision; set => SetProperty(ref _claveDivision, value); }

        [Display(Name = "Nombre de la división")]
        public string NombreDivision { get => _nombreDivision; set => SetProperty(ref _nombreDivision, value); }

        [Display(Name = "Fecha de modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
