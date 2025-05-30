using PP_Nominas.Models.Catalogos.Nomina;
using PP_Nominas.Dtos.Catalogos.Nomina;

namespace PP_Nominas.Converters.Catalogos.Nomina
{
    public static class ConceptoFiniquitoConverter
    {
        public static ConceptoFiniquitoDto ToDto(ConceptoFiniquito model)
        {
            return new ConceptoFiniquitoDto
            {
                FiniquitoLiquidacionId = model.FiniquitoLiquidacionId ?? string.Empty,
                Codigo = model.Codigo ?? string.Empty,
                Descripcion = model.Descripcion ?? string.Empty,
                EsPercepcion = model.EsPercepcion,
                Importe = model.Importe,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static ConceptoFiniquito ToModel(ConceptoFiniquitoDto dto)
        {
            return new ConceptoFiniquito
            {
                FiniquitoLiquidacionId = dto.FiniquitoLiquidacionId ?? string.Empty,
                Codigo = dto.Codigo ?? string.Empty,
                Descripcion = dto.Descripcion ?? string.Empty,
                EsPercepcion = dto.EsPercepcion,
                Importe = dto.Importe,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
