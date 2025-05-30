using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    /// <summary>
    /// Representa la clase CatalogoEntidadesDto.
    /// </summary>
    public class CatalogoEntidadesDto
    {
        [Display(Name = "ID único de la entidad")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Código corto de la entidad (uso polimórfico)")]
        
        /// <summary>
        /// Obtiene o establece EntityCode.
        /// </summary>
        public string? EntityCode { get; set; }

        [Display(Name = "Nombre descriptivo de la entidad")]
        
        /// <summary>
        /// Obtiene o establece NombreEntidad.
        /// </summary>
        public string? NombreEntidad { get; set; }

        [Display(Name = "Módulo o microservicio donde se usa")]
        
        /// <summary>
        /// Obtiene o establece ModuloRelacionado.
        /// </summary>
        public string? ModuloRelacionado { get; set; }

        [Display(Name = "Descripción funcional de la entidad")]
        
        /// <summary>
        /// Obtiene o establece DescripcionEntidad.
        /// </summary>
        public string? DescripcionEntidad { get; set; }



    
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
