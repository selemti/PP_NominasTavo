using PP_Nominas.Models.Catalogos.Vacaciones;
using PP_Nominas.Dtos.Catalogos.Vacaciones;

namespace PP_Nominas.Converters.Catalogos.Vacaciones
{
    public static class PermisoConverter
    {
        public static PermisoDto ToDto(Permiso model)
        {
            return new PermisoDto
            {
                Id = model.Id ?? string.Empty,
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                TipoPermiso = model.TipoPermiso,
                FechaInicio = model.FechaInicio,
                FechaFin = model.FechaFin,
                RequiereSuplente = model.RequiereSuplente,
                ModalidadReposicion = model.ModalidadReposicion,
                DetalleReposicion = model.DetalleReposicion ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static Permiso ToModel(PermisoDto dto)
        {
            return new Permiso
            {
                Id = dto.Id ?? string.Empty,
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                TipoPermiso = dto.TipoPermiso,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                RequiereSuplente = dto.RequiereSuplente,
                ModalidadReposicion = dto.ModalidadReposicion,
                DetalleReposicion = dto.DetalleReposicion ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
