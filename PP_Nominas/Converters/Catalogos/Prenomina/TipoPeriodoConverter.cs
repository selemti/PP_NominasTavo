using PP_Nominas.Models.Catalogos.Prenomina;
using PP_Nominas.Dtos.Catalogos.Prenomina;

namespace PP_Nominas.Converters.Catalogos.Prenomina
{
    public static class TipoPeriodoConverter
    {
        public static TipoPeriodoDto ToDto(TipoPeriodo model)
        {
            return new TipoPeriodoDto
            {
                Id = model.Id ?? string.Empty,
                NombreTipoPeriodo = model.NombreTipoPeriodo ?? string.Empty,
                DiasPeriodo = model.DiasPeriodo, // modelo tiene int
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static TipoPeriodo ToModel(TipoPeriodoDto dto)
        {
            return new TipoPeriodo
            {
                Id = dto.Id ?? string.Empty,
                NombreTipoPeriodo = dto.NombreTipoPeriodo ?? string.Empty,
                DiasPeriodo = dto.DiasPeriodo ?? 0, // conversión explícita de int? a int
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
