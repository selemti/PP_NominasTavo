using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Organizacion
{
    public partial class Organigrama : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _divisionId = string.Empty;
        private string _puestoId = string.Empty;
        private string _centroCostoId = string.Empty;
        private string _nodoPadreId = string.Empty;
        private int? _nivel;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del nodo")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "División")]
        public string DivisionId { get => _divisionId; set => SetProperty(ref _divisionId, value); }

        [Display(Name = "Puesto")]
        public string PuestoId { get => _puestoId; set => SetProperty(ref _puestoId, value); }

        [Display(Name = "Centro de costo")]
        public string CentroCostoId { get => _centroCostoId; set => SetProperty(ref _centroCostoId, value); }

        [Display(Name = "Nodo padre")]
        public string NodoPadreId { get => _nodoPadreId; set => SetProperty(ref _nodoPadreId, value); }

        [Display(Name = "Nivel")]
        public int? Nivel { get => _nivel; set => SetProperty(ref _nivel, value); }

        [Display(Name = "Fecha modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
