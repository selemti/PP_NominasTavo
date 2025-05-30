using System;

namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class PlantillaTurnoDetalleDto
    {
        public string Id { get; set; } = string.Empty;
        public string PlantillaId { get; set; } = string.Empty;
        public DateTime? Fecha { get; set; }
        public string TurnoId { get; set; } = string.Empty;
        public string PlazaId { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
