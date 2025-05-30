using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Shared
{
    /// <summary>Representa un registro histórico de cambios en una entidad.</summary>
    public partial class HistorialDocumento : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _entidad = string.Empty;
        private string _entidadId = string.Empty;
        private string _snapshot = string.Empty;
        private DateTime _fechaCambio;
        private string _usuarioId = string.Empty;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del historial")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Entidad afectada")]
        public string Entidad { get => _entidad; set => SetProperty(ref _entidad, value); }

        [Display(Name = "ID de entidad original")]
        public string EntidadId { get => _entidadId; set => SetProperty(ref _entidadId, value); }

        [Display(Name = "Snapshot JSON")]
        public string Snapshot { get => _snapshot; set => SetProperty(ref _snapshot, value); }

        [Display(Name = "Fecha de cambio")]
        public DateTime FechaCambio { get => _fechaCambio; set => SetProperty(ref _fechaCambio, value); }

        [Display(Name = "Usuario que hizo el cambio")]
        public string UsuarioId { get => _usuarioId; set => SetProperty(ref _usuarioId, value); }

        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
