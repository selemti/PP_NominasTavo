using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Seguridad
{
    public class UsuarioDto
    {
        public string Id { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;
        public string CorreoElectronico { get; set; } = string.Empty;
        public string PerfilId { get; set; } = string.Empty;
        public int? EstatusUsuario { get; set; }
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}