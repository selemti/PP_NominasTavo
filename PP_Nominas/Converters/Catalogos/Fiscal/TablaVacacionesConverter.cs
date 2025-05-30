using PP_Nominas.Dtos.Catalogos.Fiscal;
using PP_Nominas.Models.Catalogos.Fiscal;

namespace PP_Nominas.Converters.Catalogos.Fiscal
{
    public static class TablaVacacionesConverter
    {
        public static TablaVacacionesDto ToDto(TablaVacaciones model)
        {
            if (model == null) return null!;

            return new TablaVacacionesDto
            {
                Id = model.Id,
                AniosAntiguedadMinimo = model.AniosAntiguedadMinimo,
                AniosAntiguedadMaximo = model.AniosAntiguedadMaximo,
                DiasVacaciones = model.DiasVacaciones,
                EjercicioFiscal = model.EjercicioFiscal,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static TablaVacaciones ToModel(TablaVacacionesDto dto)
        {
            if (dto == null) return null!;

            return new TablaVacaciones
            {
                Id = dto.Id,
                AniosAntiguedadMinimo = dto.AniosAntiguedadMinimo,
                AniosAntiguedadMaximo = dto.AniosAntiguedadMaximo,
                DiasVacaciones = dto.DiasVacaciones,
                EjercicioFiscal = dto.EjercicioFiscal,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
