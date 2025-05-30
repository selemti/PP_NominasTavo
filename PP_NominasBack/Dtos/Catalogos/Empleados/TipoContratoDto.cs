using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase TipoContratoDto.
    /// </summary>
    public class TipoContratoDto
    {
        [Display(Name = "ID del tipo de contrato")]
        /// <summary> Obtiene o establece Id.</summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre del contrato")]
        
        /// <summary>Obtiene o establece NombreContrato.</summary>
        public string? NombreContrato { get; set; }

        [Display(Name = "Descripción del tipo de contrato")]
        
        /// <summary>Obtiene o establece DescripcionContrato.</summary>
        public string? DescripcionContrato { get; set; }

        [Display(Name = "Clave SAT")]
        /// <summary>Obtiene o establece Clave del SAT </summary>

        public string? ClaveSat { get; set; }

        [Display(Name = "¿Está activo?")]
        /// <summary>Obtiene o establece si el contrato esta activo</summary>
        public bool Activo { get; set; }


        /// <summary>Fecha de la última modificación del documento. </summary>
        public DateTime FechaUltimaModificacion { get; set; }

        /// <summary>Identificador del usuario que realizó la última modificación.</summary>
        public string? UsuarioUltimaModificacion { get; set; }
}
}
