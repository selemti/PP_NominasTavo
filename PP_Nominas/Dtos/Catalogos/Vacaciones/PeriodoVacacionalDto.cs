using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Vacaciones
{
    public class PeriodoVacacionalDto
    {
        public string Id { get; set; } = string.Empty;
        public int? Anio { get; set; }
        public int? DiasAsignados { get; set; }
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}