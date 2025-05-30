using PP_Nominas.Dtos.Catalogos.Asistencia;
using PP_Nominas.Models.Catalogos.Asistencia;

namespace PP_Nominas.Converters
{
    public static class PlantillaMensualConverter
    {
        public static PlantillaMensualDto ToDto(this PlantillaMensual model)
        {
            if (model == null) return null!;

            return new PlantillaMensualDto
            {
                Id = model.Id,
                Mes = model.Mes,
                AO = model.AO,
                HorarioPlantillaId = model.HorarioPlantillaId,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static PlantillaMensual ToModel(this PlantillaMensualDto dto)
        {
            if (dto == null) return null!;

            return new PlantillaMensual
            {
                Id = dto.Id,
                Mes = dto.Mes,
                AO = dto.AO,
                HorarioPlantillaId = dto.HorarioPlantillaId,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
