using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Configuracion
{
    public class ConfiguracionGlobalDto
    {
        public string Id { get; set; } = string.Empty;
        public string CategoriaConfiguracion { get; set; } = string.Empty;
        public string ClaveConfiguracion { get; set; } = string.Empty;
        public string ValorConfiguracion { get; set; } = string.Empty;
        public string DescripcionConfiguracion { get; set; } = string.Empty;
        public DateTime? FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}