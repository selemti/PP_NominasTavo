using System;

namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class CatalogoEntidadesDto
    {
        public string Id { get; set; } = string.Empty;
        public string EntityCode { get; set; } = string.Empty;
        public string NombreEntidad { get; set; } = string.Empty;
        public string ModuloRelacionado { get; set; } = string.Empty;
        public string DescripcionEntidad { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
