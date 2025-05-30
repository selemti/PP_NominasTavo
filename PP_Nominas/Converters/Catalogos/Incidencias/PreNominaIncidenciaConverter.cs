// Converter: PreNominaIncidenciaConverter.cs
using PP_Nominas.Dtos.Catalogos.Incidencias;
using PP_Nominas.Models.Catalogos.Incidencias;

namespace PP_Nominas.Converters.Catalogos.Incidencias
{
    public static class PreNominaIncidenciaConverter
    {
        public static PreNominaIncidenciaDto ToDto(PreNominaIncidencia model) => new()
        {
            Id = model.Id ?? string.Empty,
            EmpleadoId = model.EmpleadoId ?? string.Empty,
            PeriodoNominaId = model.PeriodoNominaId ?? string.Empty,
            TipoIncidenciaId = model.TipoIncidenciaId ?? string.Empty,
            Fecha = model.Fecha,
            Duracion = model.Duracion,
            JustificanteAdjunto = model.JustificanteAdjunto ?? string.Empty,
            Estatus = model.Estatus ?? string.Empty,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
        };

        public static PreNominaIncidencia ToModel(PreNominaIncidenciaDto dto) => new()
        {
            Id = dto.Id ?? string.Empty,
            EmpleadoId = dto.EmpleadoId ?? string.Empty,
            PeriodoNominaId = dto.PeriodoNominaId ?? string.Empty,
            TipoIncidenciaId = dto.TipoIncidenciaId ?? string.Empty,
            Fecha = dto.Fecha,
            Duracion = dto.Duracion,
            JustificanteAdjunto = dto.JustificanteAdjunto ?? string.Empty,
            Estatus = dto.Estatus ?? string.Empty,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
        };
    }
}
