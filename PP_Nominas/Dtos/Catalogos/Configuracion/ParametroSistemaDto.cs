using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Configuracion
{
    public class ParametroSistemaDto
    {
        public string Id { get; set; } = string.Empty;
        public string ClaveParametro { get; set; } = string.Empty;
        public string ValorParametro { get; set; } = string.Empty;
        public string DescripcionParametro { get; set; } = string.Empty;
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}