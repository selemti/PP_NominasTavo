using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Compensaciones
{
    public class EmpleadoCompensacionDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public string CompensacionId { get; set; } = string.Empty;
        public decimal? Valor { get; set; }
        public int? TipoAsignacion { get; set; }
        public string Formula { get; set; } = string.Empty;
        public int? Periodicidad { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Vigente { get; set; } = false;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}