using System;

namespace PP_Nominas.Dtos.Catalogos.Deducciones
{
    public class EmpleadoDeduccionDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public string DeduccionId { get; set; } = string.Empty;
        public decimal? Valor { get; set; }
        public int? Periodicidad { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
