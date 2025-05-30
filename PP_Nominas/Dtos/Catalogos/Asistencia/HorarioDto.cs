using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class HorarioDto
    {
        public string Id { get; set; } = string.Empty;
        public int? TipoHorario { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
