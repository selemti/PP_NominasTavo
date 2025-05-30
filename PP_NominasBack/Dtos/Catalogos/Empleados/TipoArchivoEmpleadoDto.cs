using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>DTO que representa el catálogo de tipos de archivo/documento requeridos para empleados.</summary>
    public class TipoArchivoEmpleadoDto
    {
        /// <summary>ID del tipo de documento.</summary>
        [Display(Name = "ID del tipo de archivo")]
        public string? Id { get; set; } = string.Empty;

        /// <summary>Código del tipo (ej. CURP, INE).</summary>
        [Display(Name = "Código corto del tipo")]
        
        public string? Codigo { get; set; } = string.Empty;

        /// <summary>Nombre del documento.</summary>
        [Display(Name = "Nombre del documento")]
        
        public string? Nombre { get; set; } = string.Empty;

        /// <summary>¿Es obligatorio cargar este documento?</summary>
        [Display(Name = "Es obligatorio cargarlo")]
        public bool? Requerido { get; set; }

        /// <summary>Fecha de la última modificación.</summary>
        public DateTime FechaUltimaModificacion { get; set; }

        /// <summary>Usuario que realizó la última modificación.</summary>
        public string? UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
