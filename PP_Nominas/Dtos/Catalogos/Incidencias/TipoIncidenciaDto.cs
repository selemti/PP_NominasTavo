using System;

namespace PP_Nominas.Dtos.Catalogos.Incidencias
{
    public class TipoIncidenciaDto
    {
        public string Id { get; set; } = string.Empty;
        public string NombreTipoIncidencia { get; set; } = string.Empty;
        public string DescripcionTipoIncidencia { get; set; } = string.Empty;
        public bool RequiereJustificante { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
