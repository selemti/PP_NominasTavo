using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    /// <summary>Dirección postal de una persona o lugar de trabajo.</summary>
    public class DireccionDto
    {
        /// <summary>ID único de la dirección.</summary>
        [Display(Name = "ID de dirección")]
        public string? Id { get; set; }

        /// <summary>Calle principal.</summary>
        
        [Display(Name = "Calle")]
        public string? Calle { get; set; }

        /// <summary>Número exterior.</summary>
        [Display(Name = "Número exterior")]
        public string? NumeroExterior { get; set; }

        /// <summary>Número interior.</summary>
        [Display(Name = "Número interior")]
        public string? NumeroInterior { get; set; }

        /// <summary>Colonia o fraccionamiento.</summary>
        [Display(Name = "Colonia")]
        public string? Colonia { get; set; }

        /// <summary>Código postal.</summary>
        
        [RegularExpression(@"^\d{5}$", ErrorMessage = "El código postal debe tener 5 dígitos.")]
        [Display(Name = "Código Postal")]
        public string? CodigoPostal { get; set; }

        /// <summary>Localidad o barrio.</summary>
        [Display(Name = "Localidad")]
        public string? Localidad { get; set; }

        /// <summary>Municipio o delegación.</summary>
        [Display(Name = "Municipio")]
        public string? Municipio { get; set; }

        /// <summary>Entidad federativa (estado).</summary>
        
        [Display(Name = "Entidad federativa")]
        public string? EntidadFederativa { get; set; }

        /// <summary>País de residencia.</summary>
        
        [Display(Name = "País")]
        public string? Pais { get; set; } = "México";

        /// <summary>¿Es la dirección principal?</summary>
        [Display(Name = "Principal")]
        public bool Principal { get; set; }

        /// <summary>Notas u observaciones.</summary>
        [Display(Name = "Observaciones")]
        public string? Observaciones { get; set; }

        /// <summary>Fecha de última modificación.</summary>
        [Display(Name = "Última modificación")]
        public DateTime FechaUltimaModificacion { get; set; }

        /// <summary>Usuario que realizó la modificación.</summary>
        [Display(Name = "Usuario modificación")]
        public string? UsuarioUltimaModificacion { get; set; }
    }
}
