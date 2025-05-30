using System;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class DocumentoEmpleadoDto
    {
        public string Id { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string NombreArchivo { get; set; } = string.Empty;
        public bool Validado { get; set; }
        public string TipoDocumento { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string UrlArchivo { get; set; } = string.Empty;
        public DateTime FechaEntrega { get; set; } = DateTime.MinValue;
        public bool EsObligatorio { get; set; }
        public bool EstaVigente { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
