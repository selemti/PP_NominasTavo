using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;
using PP_Nominas.Converters.Catalogos.Empleados;
using PP_Nominas.Converters.Catalogos.Shared;
using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Shared;
using System.Linq;
using PP_Nominas.Converters.Catalogos.Asistencia;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static EmpleadoCreacionDto GenerarDtoDesdeModel(Empleado model)
    {
        return new EmpleadoCreacionDto
        {
            NumeroEmpleado = model.NumeroEmpleado,
            Persona = PersonaConverter.GenerarDtoDesdeModel(model.Persona),
            Nss = model.Nss,
            FechaIngreso = model.FechaIngreso,
            TipoContrato = (int?)model.TipoContrato,
            TipoHorario = (int?)model.TipoHorario,
            EstatusEmpleado = (int?)model.EstatusEmpleado,
            DatosPago = model.DatosPago != null ? DatosPagoEmpleadoConverter.GenerarDtoDesdeModel(model.DatosPago) : null,
            Asignaciones = model.Asignaciones?.Select(AsignacionPlazaEmpleadoConverter.GenerarDtoDesdeModel).ToList(),
            Horarios = model.Horarios?.Select(HorarioEmpleadoConverter.GenerarDtoDesdeModel).ToList(),
            RegistrosImss = model.RegistrosImss?.Select(RegistroImssConverter.GenerarDtoDesdeModel).ToList(),
            HistorialUbicaciones = model.HistorialUbicaciones?.Select(UbicacionEmpleadoConverter.GenerarDtoDesdeModel).ToList(),
            Documentos = model.Documentos?.Select(DocumentoEmpleadoConverter.GenerarDtoDesdeModel).ToList(),
            ContactosEmergencia = model.ContactosEmergencia?.Select(ContactoEmergenciaConverter.GenerarDtoDesdeModel).ToList(),
            CorreoCorporativo = model.CorreoCorporativo,
            UsuarioRed = model.UsuarioRed,
            IdBiometrico = model.IdBiometrico,
            FotoPerfilUrl = model.FotoPerfilUrl,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };
    }

}
