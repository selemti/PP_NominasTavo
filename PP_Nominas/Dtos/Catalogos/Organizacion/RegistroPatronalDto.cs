using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Organizacion
{
    public class RegistroPatronalDto
    {
        public string Id { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Rfc { get; set; } = string.Empty;
        public string NumeroRegistro { get; set; } = string.Empty;
        public string Subdelegacion { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}