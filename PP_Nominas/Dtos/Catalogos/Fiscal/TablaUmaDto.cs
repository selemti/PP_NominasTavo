// DTO (ya lo tienes correcto)
namespace PP_Nominas.Dtos.Catalogos.Fiscal
{
    public class TablaUmaDto
    {
        public string Id { get; set; } = string.Empty;
        public decimal? ValorUma { get; set; }
        public DateTime? FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public int? EjercicioFiscal { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
