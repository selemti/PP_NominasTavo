using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Organizacion
{
    public class OrganigramaDto
    {
        public string Id { get; set; } = string.Empty;
        public string DivisionId { get; set; } = string.Empty;
        public string PuestoId { get; set; } = string.Empty;
        public string CentroCostoId { get; set; } = string.Empty;
        public string NodoPadreId { get; set; } = string.Empty;
        public int? Nivel { get; set; }
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}