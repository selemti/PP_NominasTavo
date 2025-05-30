using System;

namespace PP_Nominas.Dtos.Catalogos.Incidencias
{
    public class IncapacidadMedicaDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public int? TipoIncapacidad { get; set; }
        public int? DiasIncapacidad { get; set; }
        public string FolioImss { get; set; } = string.Empty;
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
