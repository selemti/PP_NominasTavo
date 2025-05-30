using PP_Nominas.Dtos.Catalogos.Configuracion;
using PP_Nominas.Models.Catalogos.Configuracion;

namespace PP_Nominas.Converters.Catalogos.Configuracion
{
    public static class ConfiguracionGlobalConverter
    {
        // De DTO a Modelo
        public static ConfiguracionGlobal ToModel(this ConfiguracionGlobalDto dto)
        {
            if (dto == null) return null!;

            return new ConfiguracionGlobal
            {
                Id = dto.Id,
                CategoriaConfiguracion = dto.CategoriaConfiguracion,
                ClaveConfiguracion = dto.ClaveConfiguracion,
                ValorConfiguracion = dto.ValorConfiguracion,
                DescripcionConfiguracion = dto.DescripcionConfiguracion,
                FechaInicioVigencia = dto.FechaInicioVigencia,
                FechaFinVigencia = dto.FechaFinVigencia,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion,
            };
        }

        // De Modelo a DTO
        public static ConfiguracionGlobalDto ToDto(this ConfiguracionGlobal model)
        {
            if (model == null) return null!;

            return new ConfiguracionGlobalDto
            {
                Id = model.Id,
                CategoriaConfiguracion = model.CategoriaConfiguracion,
                ClaveConfiguracion = model.ClaveConfiguracion,
                ValorConfiguracion = model.ValorConfiguracion,
                DescripcionConfiguracion = model.DescripcionConfiguracion,
                FechaInicioVigencia = model.FechaInicioVigencia,
                FechaFinVigencia = model.FechaFinVigencia,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion,
            };
        }
    }
}
