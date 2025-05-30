using System;

namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class PlantillaMensualDto
    {
        public string Id { get; set; } = string.Empty;
        public int? Mes { get; set; }
        public int? AO { get; set; } // Año (año)
        public string HorarioPlantillaId { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
