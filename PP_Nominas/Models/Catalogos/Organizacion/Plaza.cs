using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Organizacion
{
    public partial class Plaza : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _clavePlaza = string.Empty;
        private string _nombrePlaza = string.Empty;
        private string _puestoId = string.Empty;
        private string _departamentoId = string.Empty;
        private int? _estatusPlaza;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la plaza")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Clave")]
        public string ClavePlaza { get => _clavePlaza; set => SetProperty(ref _clavePlaza, value); }

        [Display(Name = "Nombre")]
        public string NombrePlaza { get => _nombrePlaza; set => SetProperty(ref _nombrePlaza, value); }

        [Display(Name = "Puesto")]
        public string PuestoId { get => _puestoId; set => SetProperty(ref _puestoId, value); }

        [Display(Name = "Departamento")]
        public string DepartamentoId { get => _departamentoId; set => SetProperty(ref _departamentoId, value); }

        [Display(Name = "Estatus")]
        public int? EstatusPlaza { get => _estatusPlaza; set => SetProperty(ref _estatusPlaza, value); }

        [Display(Name = "Fecha modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
