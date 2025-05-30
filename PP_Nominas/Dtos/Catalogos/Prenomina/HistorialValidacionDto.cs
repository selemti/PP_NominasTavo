using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Prenomina
{
    public class HistorialValidacionDto
    {
        public string Id { get; set; } = string.Empty;
        public string PeriodoNominaId { get; set; } = string.Empty;
        public string UsuarioValidadorId { get; set; } = string.Empty;
        public string Resultado { get; set; } = string.Empty;
        public DateTime? FechaValidacion { get; set; }
        public string Observaciones { get; set; } = string.Empty;
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}