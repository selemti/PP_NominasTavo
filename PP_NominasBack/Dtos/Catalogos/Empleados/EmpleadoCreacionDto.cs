using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Dtos.Catalogos.Asistencia;
using PP_NominasBack.Dtos.Catalogos.Empleados;
using PP_NominasBack.Dtos.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>
    /// DTO especial para la creación completa del empleado con sus subentidades.
    /// </summary>
    public class EmpleadoCreacionDto
    {
        /// <summary>Número de empleado que será asignado automáticamente.</summary>
        public string? NumeroEmpleado { get; set; }

        /// <summary>Objeto persona completo a insertar.</summary>
        
        public PersonaDto? Persona { get; set; }

        /// <summary>Número de seguridad social.</summary>
        
        public string? Nss { get; set; }

        /// <summary>Fecha de ingreso.</summary>
        public DateTime FechaIngreso { get; set; } = DateTime.Now;

        /// <summary>Tipo de contrato.</summary>
        
        public int? TipoContrato { get; set; }

        /// <summary>Tipo de horario.</summary>
        
        public int? TipoHorario { get; set; }

        /// <summary>Estatus del empleado.</summary>
        
        public int? EstatusEmpleado { get; set; }

        /// <summary>Asignaciones de plaza iniciales.</summary>
        public List<AsignacionPlazaEmpleadoDto>? Asignaciones { get; set; } = new();

        /// <summary>Historial de ubicación (opcional).</summary>
        public List<UbicacionEmpleadoDto>? HistorialUbicaciones { get; set; } = new();

        /// <summary>Registros IMSS (opcional).</summary>
        public List<RegistroImssDto>? RegistrosImss { get; set; } = new();

        /// <summary>Horarios asignados (opcional).</summary>
        public List<HorarioEmpleadoDto>? Horarios { get; set; } = new();

        /// <summary>Datos bancarios y forma de pago.</summary>
        public DatosPagoEmpleadoDto? DatosPago { get; set; }

        /// <summary>Documentos del expediente (opcional).</summary>
        public List<DocumentoEmpleadoDto>? Documentos { get; set; } = new();

        /// <summary>Contactos de emergencia (opcional).</summary>
        public List<ContactoEmergenciaDto>? ContactosEmergencia { get; set; } = new();

        /// <summary>Correo institucional.</summary>
        public string? CorreoCorporativo { get; set; }

        /// <summary>Usuario de red.</summary>
        public string? UsuarioRed { get; set; }

        /// <summary>ID biométrico (asistencia).</summary>
        public string? IdBiometrico { get; set; }

        /// <summary>Foto de perfil (opcional).</summary>
        public string? FotoPerfilUrl { get; set; }

        /// <summary>Fecha de última modificación.</summary>
        public DateTime FechaUltimaModificacion { get; set; }

        /// <summary>Usuario que realizó la última modificación.</summary>
        public string? UsuarioUltimaModificacion { get; set; }
    }
}
