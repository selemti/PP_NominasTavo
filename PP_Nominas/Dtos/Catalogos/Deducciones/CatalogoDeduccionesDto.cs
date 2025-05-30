namespace PP_Nominas.Dtos.Catalogos.Deducciones
{
    public class CatalogoDeduccionesDto
    {
        public string Id { get; set; } = string.Empty;
        public int? TipoDeduccion { get; set; }
        public string NombreDeduccion { get; set; } = string.Empty;
        public string DescripcionDeduccion { get; set; } = string.Empty;
        public string AplicaEmpresaId { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
