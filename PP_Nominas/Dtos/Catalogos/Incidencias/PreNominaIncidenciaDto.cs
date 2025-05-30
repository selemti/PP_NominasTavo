using System;

namespace PP_Nominas.Dtos.Catalogos.Incidencias
{
    public class PreNominaIncidenciaDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public string PeriodoNominaId { get; set; } = string.Empty;
        public string TipoIncidenciaId { get; set; } = string.Empty;
        public DateTime? Fecha { get; set; }
        public decimal? Duracion { get; set; }
        public string JustificanteAdjunto { get; set; } = string.Empty;
        public string Estatus { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; }
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}