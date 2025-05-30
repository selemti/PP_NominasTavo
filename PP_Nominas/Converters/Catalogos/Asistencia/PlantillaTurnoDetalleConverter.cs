using PP_Nominas.Dtos.Catalogos.Asistencia;
using PP_Nominas.Models.Catalogos.Asistencia;

namespace PP_Nominas.Converters
{
    public static class PlantillaTurnoDetalleConverter
    {
        public static PlantillaTurnoDetalleDto ToDto(this PlantillaTurnoDetalle model)
        {
            if (model == null) return null!;

            return new PlantillaTurnoDetalleDto
            {
                Id = model.Id,
                PlantillaId = model.PlantillaId,
                Fecha = model.Fecha,
                TurnoId = model.TurnoId,
                PlazaId = model.PlazaId,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static PlantillaTurnoDetalle ToModel(this PlantillaTurnoDetalleDto dto)
        {
            if (dto == null) return null!;

            return new PlantillaTurnoDetalle
            {
                Id = dto.Id,
                PlantillaId = dto.PlantillaId,
                Fecha = dto.Fecha,
                TurnoId = dto.TurnoId,
                PlazaId = dto.PlazaId,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
