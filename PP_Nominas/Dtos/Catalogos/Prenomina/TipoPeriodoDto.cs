using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Prenomina
{
    public class TipoPeriodoDto
    {
        public string Id { get; set; } = string.Empty;
        public string NombreTipoPeriodo { get; set; } = string.Empty;
        public int? DiasPeriodo { get; set; }
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}