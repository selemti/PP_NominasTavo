using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Seguridad
{
    public class PerfilDto
    {
        public string Id { get; set; } = string.Empty;
        public string NombrePerfil { get; set; } = string.Empty;
        public string DescripcionPerfil { get; set; } = string.Empty;
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}