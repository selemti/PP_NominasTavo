using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Organizacion
{
    public class EmpresaCentroTrabajoDto
    {
        public string Id { get; set; } = string.Empty;
        public string GrupoEmpresaId { get; set; } = string.Empty;
        public string CentroTrabajoId { get; set; } = string.Empty;
        public bool? Vigente { get; set; }
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}