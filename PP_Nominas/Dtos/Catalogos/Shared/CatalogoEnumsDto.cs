// Dtos/Catalogos/Shared/CatalogoEnumsDto.cs
using System.Collections.Generic;
using System;
namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class CatalogoEnumsDto
    {
        public int Key { get; set; }
        public string Value { get; set; } = string.Empty;
    }
    public class CatalogoEnumsCollectionDto
    {
        public string CatalogName { get; set; } = string.Empty;
        public List<CatalogoEnumsDto> Items { get; set; } = new();
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}