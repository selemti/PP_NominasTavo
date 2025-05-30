using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Nomina
{
    public class CatalogoPrestacionesDto
    {
        public string Id { get; set; } = string.Empty;
        public string NombrePrestacion { get; set; } = string.Empty;
        public string DescripcionPrestacion { get; set; } = string.Empty;
        public string AplicaEmpresaId { get; set; } = string.Empty;
        public string AplicaDivisionId { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}