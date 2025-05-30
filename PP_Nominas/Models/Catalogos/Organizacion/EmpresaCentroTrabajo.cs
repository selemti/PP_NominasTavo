using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Organizacion
{
    public partial class EmpresaCentroTrabajo : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _grupoEmpresaId = string.Empty;
        private string _centroTrabajoId = string.Empty;
        private bool? _vigente;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la relación empresa-centro")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Empresa")]
        public string GrupoEmpresaId { get => _grupoEmpresaId; set => SetProperty(ref _grupoEmpresaId, value); }

        [Display(Name = "Centro de trabajo")]
        public string CentroTrabajoId { get => _centroTrabajoId; set => SetProperty(ref _centroTrabajoId, value); }

        [Display(Name = "¿Vigente?")]
        public bool? Vigente { get => _vigente; set => SetProperty(ref _vigente, value); }

        [Display(Name = "Fecha de modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
