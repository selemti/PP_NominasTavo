using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class AuditableDto
    {
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaUltimaModificacion { get; set; }
        public string UsuarioCreadorId { get; set; } = string.Empty;
        public string UsuarioModificadorId { get; set; } = string.Empty;

    } 
}