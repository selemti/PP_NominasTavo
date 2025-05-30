using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Dtos.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    /// <summary>DTO para los datos personales del empleado.</summary>
    public class PersonaDto
    {
        /// <summary>ID único de la persona.</summary>
        [Display(Name = "ID de persona")]
        public string? Id { get; set; }

        /// <summary>Nombre(s) del empleado.</summary>
        
        [Display(Name = "Nombre(s)")]
        public string? Nombre { get; set; }

        /// <summary>Apellido paterno del empleado.</summary>
        
        [Display(Name = "Apellido paterno")]
        public string? ApellidoPaterno { get; set; }

        /// <summary>Apellido materno del empleado.</summary>
        [Display(Name = "Apellido materno")]
        public string? ApellidoMaterno { get; set; }

        /// <summary>Fecha de nacimiento del empleado.</summary>
        
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        /// <summary>Sexo del empleado.</summary>
        
        [Display(Name = "Sexo")]
        public SexoEnum Sexo { get; set; }

        /// <summary>Estado civil del empleado.</summary>
        [Display(Name = "Estado civil")]
        public EstadoCivilEnum? EstadoCivil { get; set; }

        /// <summary>CURP del empleado.</summary>
        
        [StringLength(18)]
        [Display(Name = "CURP")]
        public string? Curp { get; set; }

        /// <summary>RFC del empleado.</summary>
        
        [StringLength(13)]
        [Display(Name = "RFC")]
        public string? Rfc { get; set; }

        [Display(Name = "Correo personal")]
        /// <summary>Correo electrónico personal del empleado.</summary>
        [EmailAddress]
        public string? CorreoPersonal { get; set; }

        /// <summary>Nacionalidad del empleado.</summary>
        [Display(Name = "Nacionalidad")]
        public string? Nacionalidad { get; set; }

        /// <summary>Tipo de sangre del empleado.</summary>
        [Display(Name = "Tipo de sangre")]
        public TipoSangreEnum? TipoSangre { get; set; }

        /// <summary>Nivel de estudios del empleado.</summary>
        [Display(Name = "Nivel de estudios")]
        public NivelEstudioEnum? NivelEstudio { get; set; }

        /// <summary>Teléfonos del empleado.</summary>
        [Display(Name = "Teléfonos")]
        public List<TelefonoDto> Telefonos { get; set; } = new();

        /// <summary>Direcciones del empleado.</summary>
        [Display(Name = "Dirección principal")]
        public DireccionDto? Direccion { get; set; }

        /// <summary>Fecha de la última modificación.</summary>
        public DateTime FechaUltimaModificacion { get; set; }

        /// <summary>Usuario que modificó por última vez el registro.</summary>
        public string? UsuarioUltimaModificacion { get; set; }
    }
}
