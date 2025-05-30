using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Nomina
{
    public class ResponsableNominaDto
    {
        public string Id { get; set; } = string.Empty;
        public string UsuarioId { get; set; } = string.Empty;
        public string TipoResponsabilidad { get; set; } = string.Empty;
        public string CentroPagoNominaId { get; set; } = string.Empty;
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}