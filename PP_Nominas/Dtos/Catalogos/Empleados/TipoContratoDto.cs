using System;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class TipoContratoDto
    {
        public string Id { get; set; } = string.Empty;
        public string NombreContrato { get; set; } = string.Empty;
        public string DescripcionContrato { get; set; } = string.Empty;
        public string ClaveSat { get; set; } = string.Empty;
        public bool Activo { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
