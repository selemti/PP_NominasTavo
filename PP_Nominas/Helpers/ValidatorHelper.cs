using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using PP_Nominas.Models.Catalogos.Asistencia;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Models.Catalogos.Organizacion;
using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Models.Catalogos.Vacaciones;

namespace PP_Nominas.Helpers
{
    public static class ValidatorHelper
    {
        public static Dictionary<string, string> Validate(object instance)
        {
            var errores = new Dictionary<string, string>();

            if (instance == null) return errores;

            var context = new ValidationContext(instance, null, null);
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(instance, context, results, true);

            foreach (var result in results)
            {
                foreach (var member in result.MemberNames.DefaultIfEmpty(""))
                    errores[member] = result.ErrorMessage ?? "Error desconocido.";
            }

            // ────────────── VALIDACIONES PERSONALIZADAS ──────────────

            if (instance is Persona persona)
            {
                if (!Regex.IsMatch(persona.Curp, @"^[A-Z]{4}\d{6}[HM][A-Z]{5}[0-9A-Z]{2}$", RegexOptions.IgnoreCase))
                    errores[nameof(persona.Curp)] = "CURP inválido.";

                if (!Regex.IsMatch(persona.Rfc, @"^([A-ZÑ&]{3,4})\d{6}([A-Z\d]{3})$", RegexOptions.IgnoreCase))
                    errores[nameof(persona.Rfc)] = "RFC inválido.";

                if (persona.FechaNacimiento > DateTime.Today.AddYears(-15))
                    errores[nameof(persona.FechaNacimiento)] = "Debe tener al menos 15 años.";

                if (string.IsNullOrWhiteSpace(persona.Nacionalidad))
                    errores[nameof(persona.Nacionalidad)] = "La nacionalidad es requerida.";

                foreach (var tel in persona.Telefonos)
                {
                    if (!Regex.IsMatch(tel.Numero ?? "", @"^\d{7,10}$"))
                        errores[$"Telefono.{tel.Tipo}"] = "Número inválido. Debe tener de 7 a 10 dígitos.";
                }

                if (!Regex.IsMatch(persona.CorreoPersonal ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    errores[nameof(persona.CorreoPersonal)] = "Correo personal no válido.";

                var dir = persona.Direccion;
                if (dir != null)
                {
                    if (!Regex.IsMatch(dir.CodigoPostal ?? "", @"^\d{5}$"))
                        errores["Direccion.CodigoPostal"] = "Código Postal inválido.";
                    if (string.IsNullOrWhiteSpace(dir.Calle))
                        errores["Direccion.Calle"] = "La calle es requerida.";
                    if (string.IsNullOrWhiteSpace(dir.Colonia))
                        errores["Direccion.Colonia"] = "La colonia es requerida.";
                    if (string.IsNullOrWhiteSpace(dir.Localidad))
                        errores["Direccion.Localidad"] = "La localidad es requerida.";
                    if (string.IsNullOrWhiteSpace(dir.Municipio))
                        errores["Direccion.Municipio"] = "El municipio es requerido.";
                    if (string.IsNullOrWhiteSpace(dir.EntidadFederativa))
                        errores["Direccion.EntidadFederativa"] = "El estado es requerido.";
                }
            }

            if (instance is Empleado empleado)
            {
                if (!Regex.IsMatch(empleado.Nss ?? "", @"^\d{2}(0[1-9]|1[0-2])\d{2}\d{5}$"))
                    errores[nameof(empleado.Nss)] = "NSS inválido.";

                if (string.IsNullOrWhiteSpace(empleado.NumeroEmpleado))
                    errores[nameof(empleado.NumeroEmpleado)] = "El número de empleado es obligatorio.";

                if (empleado.Persona == null)
                    errores[nameof(empleado.Persona)] = "Datos personales requeridos.";
                else
                {
                    var nested = Validate(empleado.Persona);
                    foreach (var kv in nested) errores[kv.Key] = kv.Value;
                }

                if (!string.IsNullOrWhiteSpace(empleado.CorreoCorporativo) &&
                    !Regex.IsMatch(empleado.CorreoCorporativo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    errores[nameof(empleado.CorreoCorporativo)] = "Correo corporativo inválido.";
            }

            if (instance is Vacacion vac)
            {
                if (vac.FechaInicio == null)
                    errores[nameof(vac.FechaInicio)] = "La fecha de inicio es requerida.";

                if (vac.FechaFin == null)
                    errores[nameof(vac.FechaFin)] = "La fecha de fin es requerida.";

                if (vac.DiasProgramados == null || vac.DiasProgramados <= 0)
                    errores[nameof(vac.DiasProgramados)] = "Debe indicar los días programados.";

                if (string.IsNullOrWhiteSpace(vac.PeriodoVacacionalId))
                    errores[nameof(vac.PeriodoVacacionalId)] = "Debe indicar el periodo vacacional.";
            }

            if (instance is Permiso permiso)
            {
                if (permiso.FechaInicio == null)
                    errores[nameof(permiso.FechaInicio)] = "Debe indicar la fecha de inicio.";
                if (permiso.FechaFin == null)
                    errores[nameof(permiso.FechaFin)] = "Debe indicar la fecha de fin.";
                if (permiso.RequiereSuplente == true && string.IsNullOrWhiteSpace(permiso.DetalleReposicion))
                    errores[nameof(permiso.DetalleReposicion)] = "Debe indicar cómo se repondrá el tiempo.";
            }

            if (instance is Ubicacion ubicacion)
            {
                if (ubicacion.Latitud == null || ubicacion.Longitud == null)
                {
                    errores[nameof(ubicacion.Latitud)] = "Debe especificar latitud y longitud válidas.";
                }

                if (ubicacion.Radio == null || ubicacion.Radio <= 0)
                    errores[nameof(ubicacion.Radio)] = "Debe indicar un radio válido.";

                if (ubicacion.TipoUbicacion is < 1 or > 2)
                    errores[nameof(ubicacion.TipoUbicacion)] = "Tipo de ubicación inválido.";
            }

            if (instance is CentroTrabajo ct)
            {
                if (ct.TipoCentroTrabajo == null || ct.TipoCentroTrabajo <= 0)
                    errores[nameof(ct.TipoCentroTrabajo)] = "Tipo de centro de trabajo inválido.";
            }

            if (instance is Puesto puesto)
            {
                if (puesto.NivelPuesto == null || puesto.NivelPuesto < 1)
                    errores[nameof(puesto.NivelPuesto)] = "El nivel del puesto debe ser mayor a 0.";
            }

            if (instance is HorarioEmpleado horario)
            {
                if (string.IsNullOrWhiteSpace(horario.TurnoId))
                    errores[nameof(horario.TurnoId)] = "Debe seleccionar un turno.";

                if (horario.FechaInicio == default)
                    errores[nameof(horario.FechaInicio)] = "La fecha de inicio es obligatoria.";
            }

            if (instance is ContratoEmpleado contrato)
            {
                if (contrato.TipoContrato == null)
                    errores[nameof(contrato.TipoContrato)] = "El tipo de contrato es obligatorio.";

                if (contrato.FechaInicioContrato == null)
                    errores[nameof(contrato.FechaInicioContrato)] = "Debe indicar la fecha de inicio.";
            }

            return errores;
        }
    
    
    }
}
