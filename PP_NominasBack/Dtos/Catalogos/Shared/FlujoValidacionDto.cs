using MongoDB.Bson;

using System;
namespace PP_NominasFront.Models.Shared
{
    /// <summary>
    /// Representa la clase FlujoValidacionDto.
    /// </summary>
    public class FlujoValidacionDto
    {
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// Obtiene o establece Activo.
        /// </summary>
        public bool Activo { get; set; }
        /// <summary>
        /// Obtiene o establece DescripcionFlujo.
        /// </summary>
        public string? DescripcionFlujo { get; set; }
        /// <summary>
        /// Obtiene o establece NombreFlujo.
        /// </summary>
        public string? NombreFlujo { get; set; }
        /// <summary>
        /// Obtiene o establece ProcesoRelacionado.
        /// </summary>
        public string? ProcesoRelacionado { get; set; }
    
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
