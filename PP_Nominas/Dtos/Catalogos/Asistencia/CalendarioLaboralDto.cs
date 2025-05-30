using System;
using System.Collections.Generic;

namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class CalendarioLaboralDto
    {
        public string Id { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public int TipoDia { get; set; }
        public string DescripcionEvento { get; set; } = string.Empty;
        public string EmpresaId { get; set; } = string.Empty;
        public string DivisionId { get; set; } = string.Empty;
        public bool? Vigente { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
