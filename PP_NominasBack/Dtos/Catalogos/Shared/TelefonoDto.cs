using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    /// <summary>
    /// Representa la clase TelefonoDto.
    /// </summary>
    public class TelefonoDto
    {
        /// <summary>ID único del teléfono.</summary>
        [Display(Name = "ID del teléfono")]
        public string? Id { get; set; }

        /// <summary>Tipo de teléfono (Ej: Celular, Casa, Oficina).</summary>
        
        [Display(Name = "Tipo de teléfono")]
        public int? Tipo { get; set; }

        /// <summary>Clave lada nacional o internacional.</summary>
        [Display(Name = "Clave LADA")]
        public string? ClaveLada { get; set; }

        /// <summary>Número telefónico.</summary>
        
        [Phone]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "El número de teléfono debe tener 10 dígitos.")]
        [Display(Name = "Número de teléfono")]
        public string? Numero { get; set; }

        /// <summary>Extensión interna (opcional).</summary>
        [Display(Name = "Extensión")]
        public string? Extension { get; set; }

        /// <summary>Indica si este es el teléfono principal.</summary>
        [Display(Name = "Principal")]
        public bool Principal { get; set; }

        /// <summary>Notas u observaciones adicionales.</summary>
        [Display(Name = "Observaciones")]
        public string? Observaciones { get; set; }

        /// <summary>Fecha de la última modificación.</summary>
        public DateTime FechaUltimaModificacion { get; set; }

        /// <summary>Usuario que modificó por última vez el registro.</summary>
        public string? UsuarioUltimaModificacion { get; set; }
    }
}
