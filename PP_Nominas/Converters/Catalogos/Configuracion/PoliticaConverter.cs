using PP_Nominas.Dtos.Catalogos.Configuracion;
using PP_Nominas.Models.Catalogos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PP_Nominas.Converters.Catalogos.Configuracion
{
    public static class PoliticaConverter
    {
        public static PoliticaDto ToDto(Politica model)
        {
            if (model == null) return new PoliticaDto();

            return new PoliticaDto
            {
                Id = model.Id,
                NombrePolitica = model.NombrePolitica,
                DescripcionPolitica = model.DescripcionPolitica,
                VersionPolitica = model.VersionPolitica,
                FechaInicioVigencia = model.FechaInicioVigencia,
                FechaFinVigencia = model.FechaFinVigencia,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static Politica ToModel(PoliticaDto dto)
        {
            if (dto == null) return new Politica();

            return new Politica
            {
                Id = dto.Id,
                NombrePolitica = dto.NombrePolitica,
                DescripcionPolitica = dto.DescripcionPolitica,
                VersionPolitica = dto.VersionPolitica,
                FechaInicioVigencia = dto.FechaInicioVigencia,
                FechaFinVigencia = dto.FechaFinVigencia,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }

        public static List<PoliticaDto> ToDtoList(IEnumerable<Politica> modelList)
        {
            return modelList?.Select(ToDto).ToList() ?? new List<PoliticaDto>();
        }

        public static List<Politica> ToModelList(IEnumerable<PoliticaDto> dtoList)
        {
            return dtoList?.Select(ToModel).ToList() ?? new List<Politica>();
        }
    }
}
