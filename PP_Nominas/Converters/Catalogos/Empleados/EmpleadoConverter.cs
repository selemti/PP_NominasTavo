using System;
using System.Linq;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;
using PP_Nominas.Converters.Catalogos.Shared;
using PP_Nominas.Converters.Catalogos.Asistencia;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class EmpleadoConverter
    {
        public static EmpleadoDto ToDto(Empleado model)
        {
            return new EmpleadoDto
            {
                Id = model.Id,
                NumeroEmpleado = model.NumeroEmpleado,
                Persona = PersonaConverter.ToDto(model.Persona),
                Nss = model.Nss,
                FechaIngreso = model.FechaIngreso,
                TipoContrato = (int)model.TipoContrato,
                TipoHorario = (int)model.TipoHorario,
                EstatusEmpleado = (int)model.EstatusEmpleado,
                DatosPago = DatosPagoEmpleadoConverter.ToDto(model.DatosPago),
                Asignaciones = model.Asignaciones.Select(AsignacionPlazaEmpleadoConverter.ToDto).ToList(),
                HistorialUbicaciones = model.HistorialUbicaciones.Select(UbicacionEmpleadoConverter.ToDto).ToList(),
                RegistrosImss = model.RegistrosImss.Select(RegistroImssConverter.ToDto).ToList(),
                Horarios = model.Horarios.Select(HorarioEmpleadoConverter.ToDto).ToList(),
                Documentos = model.Documentos.Select(DocumentoEmpleadoConverter.ToDto).ToList(),
                ContactosEmergencia = model.ContactosEmergencia.Select(ContactoEmergenciaConverter.ToDto).ToList(),
                CorreoCorporativo = model.CorreoCorporativo,
                UsuarioRed = model.UsuarioRed,
                IdBiometrico = model.IdBiometrico,
                FotoPerfilUrl = model.FotoPerfilUrl,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static Empleado ToModel(EmpleadoDto dto)
        {
            return new Empleado
            {
                Id = dto.Id,
                NumeroEmpleado = dto.NumeroEmpleado,
                Persona = PersonaConverter.ToModel(dto.Persona),
                Nss = dto.Nss,
                FechaIngreso = dto.FechaIngreso,
                TipoContrato = (TipoContratoEnum)(dto.TipoContrato ?? 0),
                TipoHorario = (TipoHorarioEnum)(dto.TipoHorario ?? 0),
                EstatusEmpleado = (EstatusEmpleadoEnum)(dto.EstatusEmpleado ?? 0),
                DatosPago = DatosPagoEmpleadoConverter.ToModel(dto.DatosPago),
                Asignaciones = dto.Asignaciones.Select(AsignacionPlazaEmpleadoConverter.ToModel).ToList(),
                HistorialUbicaciones = dto.HistorialUbicaciones.Select(UbicacionEmpleadoConverter.ToModel).ToList(),
                RegistrosImss = dto.RegistrosImss.Select(RegistroImssConverter.ToModel).ToList(),
                Horarios = dto.Horarios.Select(HorarioEmpleadoConverter.ToModel).ToList(),
                Documentos = dto.Documentos.Select(DocumentoEmpleadoConverter.ToModel).ToList(),
                ContactosEmergencia = dto.ContactosEmergencia.Select(ContactoEmergenciaConverter.ToModel).ToList(),
                CorreoCorporativo = dto.CorreoCorporativo,
                UsuarioRed = dto.UsuarioRed,
                IdBiometrico = dto.IdBiometrico,
                FotoPerfilUrl = dto.FotoPerfilUrl,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
