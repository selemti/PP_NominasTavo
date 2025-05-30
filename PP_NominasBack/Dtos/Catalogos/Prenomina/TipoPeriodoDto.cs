using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Prenomina
{
    /// <summary>
    /// Representa la clase TipoPeriodoDto.
    /// </summary>
    public class TipoPeriodoDto
    {
        [Display(Name = "ID del tipo de periodo")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre descriptivo (Quincenal, Semanal)")]
        
        /// <summary>
        /// Obtiene o establece NombreTipoPeriodo.
        /// </summary>
        public string? NombreTipoPeriodo { get; set; }

        [Display(Name = "Número de días en el periodo")]
        
        /// <summary>
        /// Obtiene o establece DiasPeriodo.
        /// </summary>
        public int? DiasPeriodo { get; set; }



    
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
