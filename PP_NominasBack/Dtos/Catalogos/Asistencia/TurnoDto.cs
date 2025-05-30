using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase TurnoDto.
    /// </summary>
    public class TurnoDto
    {
        [Display(Name = "ID único del turno")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre del turno")]
        
        /// <summary>
        /// Obtiene o establece NombreTurno.
        /// </summary>
        public string? NombreTurno { get; set; }

        [Display(Name = "Hora programada de entrada")]
        
        /// <summary>
        /// Obtiene o establece HoraEntrada.
        /// </summary>
        public string? HoraEntrada { get; set; }

        [Display(Name = "Hora programada de salida")]
        
        /// <summary>
        /// Obtiene o establece HoraSalida.
        /// </summary>
        public string? HoraSalida { get; set; }

        [Display(Name = "Tipo de turno (0 = Fijo, 1 = Flexible)")]
        
        /// <summary>
        /// Obtiene o establece TipoTurno.
        /// </summary>
        public int? TipoTurno { get; set; }



    
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
