using PP_Nominas.Dtos.Catalogos.Asistencia;
using PP_Nominas.Models.Catalogos.Asistencia;

namespace PP_Nominas.Converters
{
    public static class IncidenciaConverter
    {
        public static IncidenciaDto ToDto(this Incidencia model)
        {
            if (model == null) return null!;

            return new IncidenciaDto
            {
                TipoFalta = model.TipoFalta,
                ChecadaId = model.ChecadaId,
                EstatusIncidencia = model.EstatusIncidencia,
                DuracionRetardo = model.DuracionRetardo,
                Justificacion = model.Justificacion,
                TipoPermiso = model.TipoPermiso,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static Incidencia ToModel(this IncidenciaDto dto)
        {
            if (dto == null) return null!;

            return new Incidencia
            {
                TipoFalta = dto.TipoFalta,
                ChecadaId = dto.ChecadaId,
                EstatusIncidencia = dto.EstatusIncidencia,
                DuracionRetardo = dto.DuracionRetardo,
                Justificacion = dto.Justificacion,
                TipoPermiso = dto.TipoPermiso,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
