using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase ChecadaAgregadaDto.
    /// </summary>
    public class ChecadaAgregadaDto
    {
        [Display(Name = "Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "EmpleadoId")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Fecha")]
        
        /// <summary>
        /// Obtiene o establece Fecha.
        /// </summary>
        public DateTime Fecha { get; set; }

        [Display(Name = "HoraEntrada")]
        
        /// <summary>
        /// Obtiene o establece HoraEntrada.
        /// </summary>
        public string? HoraEntrada { get; set; }

        [Display(Name = "HoraSalida")]
        
        /// <summary>
        /// Obtiene o establece HoraSalida.
        /// </summary>
        public string? HoraSalida { get; set; }

        [Display(Name = "Observaciones")]
        
        /// <summary>
        /// Obtiene o establece Observaciones.
        /// </summary>
        public string? Observaciones { get; set; }

    
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
