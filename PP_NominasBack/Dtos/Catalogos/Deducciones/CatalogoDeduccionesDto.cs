using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Deducciones
{
    /// <summary>
    /// Representa la clase CatalogoDeduccionesDto.
    /// </summary>
    public class CatalogoDeduccionesDto
    {
        [Display(Name = "ID de la deducción")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "(0 = Fiscal, 1 = Crédito, 2 = Préstamo, 3 = Especial, 4 = FONACOT, 5 = Pensión Alimenticia, 6 = Otro, 7 = Multa Interna, 8 = Retención Judicial)")]
        
        /// <summary>
        /// Obtiene o establece TipoDeduccion.
        /// </summary>
        public int? TipoDeduccion { get; set; }

        [Display(Name = "Nombre de la deducción")]
        
        /// <summary>
        /// Obtiene o establece NombreDeduccion.
        /// </summary>
        public string? NombreDeduccion { get; set; }

        [Display(Name = "Descripción de la deducción")]
        
        /// <summary>
        /// Obtiene o establece DescripcionDeduccion.
        /// </summary>
        public string? DescripcionDeduccion { get; set; }

        [Display(Name = "Empresa aplicable")]
        
        /// <summary>
        /// Obtiene o establece AplicaEmpresaId.
        /// </summary>
        public string? AplicaEmpresaId { get; set; }



    
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
