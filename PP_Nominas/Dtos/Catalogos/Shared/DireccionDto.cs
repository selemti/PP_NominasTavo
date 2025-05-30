using System;

namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class DireccionDto
    {
        public string? Id { get; set; }
        public string Calle { get; set; } = string.Empty;
        public string? NumeroExterior { get; set; }
        public string? NumeroInterior { get; set; }
        public string Colonia { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public string Localidad { get; set; } = string.Empty;
        public string EntidadFederativa { get; set; } = string.Empty;
        public string Pais { get; set; } = "México";
        public bool Principal { get; set; }
        public string? Observaciones { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
