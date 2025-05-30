using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Organizacion
{
    public partial class Departamento : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _claveDepartamento = string.Empty;
        private string _nombreDepartamento = string.Empty;
        private string _divisionId = string.Empty;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del departamento")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Clave del departamento")]
        public string ClaveDepartamento { get => _claveDepartamento; set => SetProperty(ref _claveDepartamento, value); }

        [Display(Name = "Nombre del departamento")]
        public string NombreDepartamento { get => _nombreDepartamento; set => SetProperty(ref _nombreDepartamento, value); }

        [Display(Name = "División")]
        public string DivisionId { get => _divisionId; set => SetProperty(ref _divisionId, value); }

        [Display(Name = "Fecha de modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
