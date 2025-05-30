using System;

namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class RangoToleranciaDto
    {
        public string Id { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public int? MinutosDesde { get; set; }
        public int? MinutosHasta { get; set; }
        public bool? Penalizacion { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
