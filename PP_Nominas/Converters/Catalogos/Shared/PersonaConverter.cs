using System.Linq;
using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Shared
{
    public static class PersonaConverter
    {
        public static PersonaDto ToDto(Persona model)
        {
            return new PersonaDto
            {
                Id = model.Id,
                Nombre = model.Nombre,
                ApellidoPaterno = model.ApellidoPaterno,
                ApellidoMaterno = model.ApellidoMaterno,
                Curp = model.Curp,
                Rfc = model.Rfc,
                CorreoPersonal = model.CorreoPersonal,
                Nacionalidad = model.Nacionalidad,
                Sexo = (int)model.Sexo,
                EstadoCivil = (int?)model.EstadoCivil,
                TipoSangre = (int?)model.TipoSangre,
                NivelEstudio = (int?)model.NivelEstudios,
                FechaNacimiento = model.FechaNacimiento,
                Direccion = DireccionConverter.ToDto(model.Direccion),
                Direcciones = model.Direcciones.Select(DireccionConverter.ToDto).ToList(),
                Telefonos = model.Telefonos.Select(TelefonoConverter.ToDto).ToList(),
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static Persona ToModel(PersonaDto dto)
        {
            return new Persona
            {
                Id = dto.Id,
                Nombre = dto.Nombre,
                ApellidoPaterno = dto.ApellidoPaterno,
                ApellidoMaterno = dto.ApellidoMaterno,
                Curp = dto.Curp,
                Rfc = dto.Rfc,
                CorreoPersonal = dto.CorreoPersonal,
                Nacionalidad = dto.Nacionalidad,
                Sexo = (SexoEnum)(dto.Sexo ?? 0),
                EstadoCivil = (EstadoCivilEnum?)dto.EstadoCivil,
                TipoSangre = (TipoSangreEnum?)dto.TipoSangre,
                NivelEstudios = (NivelEstudioEnum?)dto.NivelEstudio,
                FechaNacimiento = dto.FechaNacimiento,
                Direccion = DireccionConverter.ToModel(dto.Direccion),
                Direcciones = dto.Direcciones.Select(DireccionConverter.ToModel).ToList(),
                Telefonos = dto.Telefonos.Select(TelefonoConverter.ToModel).ToList(),
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
