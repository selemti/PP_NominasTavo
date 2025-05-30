using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Organizacion
{
    public class DepartamentoDto
    {
        public string Id { get; set; } = string.Empty;
        public string ClaveDepartamento { get; set; } = string.Empty;
        public string NombreDepartamento { get; set; } = string.Empty;
        public string DivisionId { get; set; } = string.Empty;
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}