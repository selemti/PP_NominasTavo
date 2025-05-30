using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase ResponsableNominaDto.
    /// </summary>
    public class ResponsableNominaDto
    {
        [Display(Name = "ID del responsable")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Usuario que ejecuta o valida nómina")]
        
        /// <summary>
        /// Obtiene o establece UsuarioId.
        /// </summary>
        public string? UsuarioId { get; set; }

        [Display(Name = "Tipo (0 = Ejecutor, 1 = Validador)")]
        
        /// <summary>
        /// Obtiene o establece TipoResponsabilidad.
        /// </summary>
        public int? TipoResponsabilidad { get; set; }

        [Display(Name = "Centro de pago relacionado")]
        
        /// <summary>
        /// Obtiene o establece CentroPagoNominaId.
        /// </summary>
        public string? CentroPagoNominaId { get; set; }



    
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
