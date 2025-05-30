using PP_Nominas.Dtos.Catalogos.Fiscal;
using PP_Nominas.Models.Catalogos.Fiscal;

namespace PP_Nominas.Converters.Catalogos.Fiscal
{
    public static class TablaUmaConverter
    {
        public static TablaUmaDto ToDto(TablaUma model)
        {
            if (model == null) return null!;

            return new TablaUmaDto
            {
                Id = model.Id,
                ValorUma = model.ValorUma,
                FechaInicioVigencia = model.FechaInicioVigencia,
                FechaFinVigencia = model.FechaFinVigencia,
                EjercicioFiscal = model.EjercicioFiscal,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static TablaUma ToModel(TablaUmaDto dto)
        {
            if (dto == null) return null!;

            return new TablaUma
            {
                Id = dto.Id,
                ValorUma = dto.ValorUma,
                FechaInicioVigencia = dto.FechaInicioVigencia,
                FechaFinVigencia = dto.FechaFinVigencia,
                EjercicioFiscal = dto.EjercicioFiscal,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
