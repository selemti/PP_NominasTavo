using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Organizacion
{
    public class PlazaDto
    {
        public string Id { get; set; } = string.Empty;
        public string ClavePlaza { get; set; } = string.Empty;
        public string NombrePlaza { get; set; } = string.Empty;
        public string PuestoId { get; set; } = string.Empty;
        public string DepartamentoId { get; set; } = string.Empty;
        public int? EstatusPlaza { get; set; }
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}