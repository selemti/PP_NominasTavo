using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Models.Catalogos.Shared
{
    /// <summary>Representa un flujo de validación que consta de múltiples pasos.</summary>
    public partial class FlujoValidacion : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _nombreFlujo = string.Empty;
        private string _entidadReferenciaId = string.Empty;
        private string _tipoEntidadOrigen = string.Empty;
        private List<PasoFlujoValidacion> _pasos = new();
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del flujo")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Nombre del flujo")]
        public string NombreFlujo { get => _nombreFlujo; set => SetProperty(ref _nombreFlujo, value); }

        [Display(Name = "ID de la entidad asociada")]
        public string EntidadReferenciaId { get => _entidadReferenciaId; set => SetProperty(ref _entidadReferenciaId, value); }

        [Display(Name = "Tipo de entidad")]
        public string TipoEntidadOrigen { get => _tipoEntidadOrigen; set => SetProperty(ref _tipoEntidadOrigen, value); }

        [Display(Name = "Pasos del flujo")]
        public List<PasoFlujoValidacion> Pasos { get => _pasos; set => SetProperty(ref _pasos, value); }

        [Display(Name = "Fecha de modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Usuario de modificación")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
