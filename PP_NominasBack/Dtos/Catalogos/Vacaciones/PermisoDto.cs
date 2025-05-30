using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Vacaciones
{
    /// <summary>
    /// Representa la clase PermisoDto.
    /// </summary>
    public class PermisoDto
    {
        [Display(Name = "ID de la solicitud de permiso")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado que solicita permiso")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Tipo de permiso (0 = Con goce, 1 = Sin goce, 2 = Otro)")]
        
        /// <summary>
        /// Obtiene o establece TipoPermiso.
        /// </summary>
        public int? TipoPermiso { get; set; }

        [Display(Name = "Fecha inicial del permiso")]
        
        /// <summary>
        /// Obtiene o establece FechaInicio.
        /// </summary>
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "Fecha final del permiso")]
        
        /// <summary>
        /// Obtiene o establece FechaFin.
        /// </summary>
        public DateTime? FechaFin { get; set; }

        [Display(Name = "¿Se requiere suplente?")]
        
        /// <summary>
        /// Obtiene o establece RequiereSuplente.
        /// </summary>
        public bool? RequiereSuplente { get; set; }

        [Display(Name = "Tipo de reposición (0 = No repone, 1 = Mismo día, 2 = Distribuido)")]
        
        /// <summary>
        /// Obtiene o establece ModalidadReposicion.
        /// </summary>
        public int? ModalidadReposicion { get; set; }

        [Display(Name = "Descripción de cómo repondrá el tiempo")]
        
        /// <summary>
        /// Obtiene o establece DetalleReposicion.
        /// </summary>
        public string? DetalleReposicion { get; set; }



    
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
