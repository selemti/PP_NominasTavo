using MongoDB.Bson;

using System;
namespace PP_NominasFront.Models.Shared
{
    /// <summary>
    /// Representa la clase DestinatarioAlertaDto.
    /// </summary>
    public class DestinatarioAlertaDto
    {
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// Obtiene o establece AlertaId.
        /// </summary>
        public string? AlertaId { get; set; }
        /// <summary>
        /// Obtiene o establece TipoDestinatario.
        /// </summary>
        public int TipoDestinatario { get; set; }
        /// <summary>
        /// Obtiene o establece ValorDestino.
        /// </summary>
        public string? ValorDestino { get; set; }
    
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
