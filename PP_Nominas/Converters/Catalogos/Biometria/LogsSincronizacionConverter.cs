using PP_Nominas.Dtos.Catalogos.Biometria;
using PP_Nominas.Models.Catalogos.Biometria;

namespace PP_Nominas.Converters.Catalogos.Biometria
{
    public static class LogsSincronizacionConverter
    {
        public static LogsSincronizacionDto ToDto(LogsSincronizacion entity)
        {
            if (entity == null) return null!;

            return new LogsSincronizacionDto
            {
                Id = entity.Id,
                DispositivoId = entity.DispositivoId,
                FechaEvento = entity.FechaEvento,
                DescripcionLog = entity.DescripcionLog,
                FechaUltimaModificacion = entity.FechaUltimaModificacion,
                UsuarioUltimaModificacion = entity.UsuarioUltimaModificacion,
            };
        }

        public static LogsSincronizacion ToEntity(LogsSincronizacionDto dto)
        {
            if (dto == null) return null!;

            var entity = new LogsSincronizacion
            {
                Id = dto.Id,
                DispositivoId = dto.DispositivoId,
                FechaEvento = dto.FechaEvento,
                DescripcionLog = dto.DescripcionLog,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion,
            };

            return entity;
        }
    }
}
