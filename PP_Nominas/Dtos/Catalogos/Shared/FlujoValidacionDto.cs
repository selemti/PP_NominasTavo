using System;
using System.Collections.Generic;

namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class FlujoValidacionDto
    {
        public string Id { get; set; } = string.Empty;
        public string NombreFlujo { get; set; } = string.Empty;
        public string EntidadReferenciaId { get; set; } = string.Empty;
        public string TipoEntidadOrigen { get; set; } = string.Empty;
        public List<PasoFlujoValidacionDto> Pasos { get; set; } = new();
        public DateTime FechaUltimaModificacion { get; set; }
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
