using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Organizacion
{
    public class DivisionDto
    {
        public string Id { get; set; } = string.Empty;
        public string GrupoEmpresaId { get; set; } = string.Empty;
        public string ClaveDivision { get; set; } = string.Empty;
        public string NombreDivision { get; set; } = string.Empty;
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}