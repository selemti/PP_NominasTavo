using PP_Nominas.Models.Catalogos.Configuracion;
using PP_Nominas.Dtos.Catalogos.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PP_Nominas.Converters.Catalogos.Configuracion
{
    public static class ModuloConverter
    {
        public static ModuloDto ToDto(Modulo model)
        {
            return new ModuloDto
            {
                Id = model.Id,
                Nombre = model.Nombre,
                Descripcion = model.Descripcion,
                Activo = model.Activo,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static Modulo ToModel(ModuloDto dto)
        {
            return new Modulo
            {
                Id = dto.Id,
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                Activo = dto.Activo,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }

        public static List<ModuloDto> ToDtoList(List<Modulo> modelList)
        {
            return modelList.Select(m => ToDto(m)).ToList();
        }

        public static List<Modulo> ToModelList(List<ModuloDto> dtoList)
        {
            return dtoList.Select(dto => ToModel(dto)).ToList();
        }
    }
}
