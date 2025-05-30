using System;

namespace PP_Nominas.Dtos.Catalogos.Nomina
{
    public class ConceptoFiniquitoDto
    {
        public string FiniquitoLiquidacionId { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public bool EsPercepcion { get; set; }
        public decimal Importe { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
