using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Vacaciones
{
    public class PermisoDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public int? TipoPermiso { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool? RequiereSuplente { get; set; }
        public int? ModalidadReposicion { get; set; }
        public string DetalleReposicion { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}