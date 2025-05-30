using System;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class ContactoEmergenciaConverter
    {
        public static ContactoEmergenciaDto ToDto(ContactoEmergencia model)
        {
            return new ContactoEmergenciaDto
            {
                Nombre = model.Nombre ?? string.Empty,
                Parentesco = model.Parentesco ?? string.Empty,
                Telefono = model.Telefono ?? string.Empty,
                Principal = model.Principal,
                Correo = model.Correo ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static ContactoEmergencia ToModel(ContactoEmergenciaDto dto)
        {
            return new ContactoEmergencia
            {
                Nombre = dto.Nombre ?? string.Empty,
                Parentesco = dto.Parentesco ?? string.Empty,
                Telefono = dto.Telefono ?? string.Empty,
                Principal = dto.Principal,
                Correo = dto.Correo ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
