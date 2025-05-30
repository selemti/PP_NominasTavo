using System;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class TelefonoDto
    {
        public string? Id { get; set; }
        public int? Tipo { get; set; }
        public string? ClaveLada { get; set; }
        [RegularExpression(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", ErrorMessage = "Número de teléfono inválido.")]
        public string Numero { get; set; } = string.Empty;
        public string? Extension { get; set; }
        public bool Principal { get; set; }
        public string? Observaciones { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}