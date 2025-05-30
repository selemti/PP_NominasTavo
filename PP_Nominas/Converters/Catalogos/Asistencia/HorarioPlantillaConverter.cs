using PP_Nominas.Dtos.Catalogos.Asistencia;
using PP_Nominas.Models.Catalogos.Asistencia;

namespace PP_Nominas.Converters
{
    public static class HorarioPlantillaConverter
    {
        public static HorarioPlantillaDto ToDto(this HorarioPlantilla model)
        {
            if (model == null) return null!;

            return new HorarioPlantillaDto
            {
                Id = model.Id,
                NombrePlantilla = model.NombrePlantilla,
                DescripcionPlantilla = model.DescripcionPlantilla,
                TurnoId = model.TurnoId,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static HorarioPlantilla ToModel(this HorarioPlantillaDto dto)
        {
            if (dto == null) return null!;

            return new HorarioPlantilla
            {
                Id = dto.Id,
                NombrePlantilla = dto.NombrePlantilla,
                DescripcionPlantilla = dto.DescripcionPlantilla,
                TurnoId = dto.TurnoId,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
