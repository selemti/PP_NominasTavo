using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Configuracion
{
    public class PoliticaDto
    {
        public string Id { get; set; } = string.Empty;
        public string NombrePolitica { get; set; } = string.Empty;
        public string DescripcionPolitica { get; set; } = string.Empty;
        public string VersionPolitica { get; set; } = string.Empty;
        public DateTime? FechaInicioVigencia { get; set; }
        public string FechaFinVigencia { get; set; } = string.Empty;
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}