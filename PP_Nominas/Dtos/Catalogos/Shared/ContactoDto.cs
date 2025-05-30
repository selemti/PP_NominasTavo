using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class ContactoDto
    {
        public string Id { get; set; } = string.Empty;
        public string TipoEntidad { get; set; } = string.Empty;
        public string EntidadId { get; set; } = string.Empty;
        public string NombreContacto { get; set; } = string.Empty;
        public string TelefonoContacto { get; set; } = string.Empty;
        public string Parentesco { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}