using System;
namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class ChecadaRemotaDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; } = DateTime.MinValue;
        public int TipoEvento { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public string UbicacionId { get; set; } = string.Empty;
        public string FotoAdjunta { get; set; } = string.Empty;
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}