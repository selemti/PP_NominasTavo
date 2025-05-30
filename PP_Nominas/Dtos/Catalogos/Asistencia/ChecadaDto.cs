using System;
using System.Collections.Generic;

namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class ChecadaDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; }
        public int TipoEvento { get; set; }
        public string DispositivoId { get; set; } = string.Empty;
        public List<double>? HorasTrabajadas { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
