// Dtos/Catalogos/Shared/CatalogoEnumsDto.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System;
namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    /// <summary>
    /// DTO genérico para exponer colecciones de enums.
    /// </summary>
    /// <summary>
    /// Representa la clase CatalogoEnumsDto.
    /// </summary>
    public class CatalogoEnumsDto
    {
        [Display(Name = "Identificador único del elemento")]
        /// <summary>
        /// Obtiene o establece Key.
        /// </summary>
        public int Key { get; set; }

        [Display(Name = "Valor textual del enum")]
        /// <summary>
        /// Obtiene o establece Value.
        /// </summary>
        public string? Value { get; set; }
    }

    /// <summary>
    /// Contenedor para múltiples catálogos de enums.
    /// </summary>
    /// <summary>
    /// Representa la clase CatalogoEnumsCollectionDto.
    /// </summary>
    public class CatalogoEnumsCollectionDto
    {
        [Display(Name = "Nombre del catálogo (tipo de enum)")]
        /// <summary>
        /// Obtiene o establece CatalogName.
        /// </summary>
        public string? CatalogName { get; set; }

        [Display(Name = "Items del catálogo")]
        /// <summary>
        /// Obtiene o establece Items.
        /// </summary>
        public List<CatalogoEnumsDto> Items { get; set; } = new();
    
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
