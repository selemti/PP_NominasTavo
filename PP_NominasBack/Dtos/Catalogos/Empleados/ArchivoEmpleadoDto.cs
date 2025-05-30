using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase ArchivoEmpleadoDto.
    /// </summary>
    public class ArchivoEmpleadoDto
    {
        [Display(Name = "ID del archivo")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado relacionado")]
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Tipo de documento (CURP, RFC, Foto, etc.)")]
        
        /// <summary>
        /// Obtiene o establece TipoArchivo.
        /// </summary>
        public int? TipoArchivo { get; set; }

        [Display(Name = "URL del archivo digitalizado")]
        
        /// <summary>
        /// Obtiene o establece UrlArchivo.
        /// </summary>
        public string? UrlArchivo { get; set; }

        [Display(Name = "Fecha de carga del archivo")]
        
        /// <summary>
        /// Obtiene o establece FechaCarga.
        /// </summary>
        public DateTime? FechaCarga { get; set; }

        [Display(Name = "Indica si el archivo sigue válido")]
        
        /// <summary>
        /// Obtiene o establece Vigente.
        /// </summary>
        public bool? Vigente { get; set; }



    
    /// <summary>
    /// Fecha de la última modificación del documento.
    /// </summary>
    public DateTime FechaUltimaModificacion { get; set; }

    /// <summary>
    /// Identificador del usuario que realizó la última modificación.
    /// </summary>
    public string? UsuarioUltimaModificacion { get; set; }
}
}
