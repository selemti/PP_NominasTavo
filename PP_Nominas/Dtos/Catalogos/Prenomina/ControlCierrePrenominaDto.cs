using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Prenomina
{
    public class ControlCierrePrenominaDto
    {
        public string Id { get; set; } = string.Empty;
        public string PeriodoNominaId { get; set; } = string.Empty;
        public DateTime? FechaCierre { get; set; }
        public string UsuarioCierreId { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}