
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase ChecadaDto.
    /// </summary>
    public class ChecadaDto
    {
        [Display(Name = "ID de la checada")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado que registró la checada")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Fecha y hora de la checada")]
        
        /// <summary>
        /// Obtiene o establece FechaHora.
        /// </summary>
        public DateTime? FechaHora { get; set; }

        [Display(Name = "Tipo de evento (0 = Entrada, 1 = Salida)")]
        
        /// <summary>
        /// Obtiene o establece TipoEvento.
        /// </summary>
        public int? TipoEvento { get; set; }

        [Display(Name = "Dispositivo biométrico usado")]
        
        /// <summary>
        /// Obtiene o establece DispositivoId.
        /// </summary>
        public string? DispositivoId { get; set; }

        // Nueva propiedad para Horas Trabajadas
        [Display(Name = "Horas trabajadas")]
        
        /// <summary>
        /// Obtiene o establece HorasTrabajadas.
        /// </summary>
        public List<double>? HorasTrabajadas { get; set; }
    
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
