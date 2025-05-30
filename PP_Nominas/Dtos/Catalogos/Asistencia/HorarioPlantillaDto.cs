using System;

namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class HorarioPlantillaDto
    {
        public string Id { get; set; } = string.Empty;
        public string NombrePlantilla { get; set; } = string.Empty;
        public string DescripcionPlantilla { get; set; } = string.Empty;
        public string TurnoId { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
