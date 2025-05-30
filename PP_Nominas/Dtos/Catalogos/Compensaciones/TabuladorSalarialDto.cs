using System;

namespace PP_Nominas.Dtos.Catalogos.Compensaciones
{
    public class TabuladorSalarialDto
    {
        public string Id { get; set; } = string.Empty;
        public string PuestoId { get; set; } = string.Empty;
        public decimal? SalarioMinimo { get; set; }
        public decimal? SalarioMaximo { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
