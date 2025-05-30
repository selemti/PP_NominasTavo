using MongoDB.Bson;

using System;
namespace PP_NominasFront.Models.Shared
{
    /// <summary>
    /// Representa la clase PasoFlujoValidacionDto.
    /// </summary>
    public class PasoFlujoValidacionDto
    {
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// Obtiene o establece AutorizacionNecesaria.
        /// </summary>
        public bool AutorizacionNecesaria { get; set; }
        /// <summary>
        /// Obtiene o establece FlujoValidacionId.
        /// </summary>
        public string? FlujoValidacionId { get; set; }
        /// <summary>
        /// Obtiene o establece NotificarEnEstePaso.
        /// </summary>
        public bool NotificarEnEstePaso { get; set; }
        /// <summary>
        /// Obtiene o establece OrdenPaso.
        /// </summary>
        public int OrdenPaso { get; set; }
        /// <summary>
        /// Obtiene o establece ResponsableId.
        /// </summary>
        public string? ResponsableId { get; set; }
        /// <summary>
        /// Obtiene o establece TipoResponsable.
        /// </summary>
        public int TipoResponsable { get; set; }
    
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
