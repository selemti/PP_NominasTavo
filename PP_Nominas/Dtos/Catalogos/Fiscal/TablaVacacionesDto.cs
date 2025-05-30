namespace PP_Nominas.Dtos.Catalogos.Fiscal
{
    public class TablaVacacionesDto
    {
        public string Id { get; set; } = string.Empty;
        public int? AniosAntiguedadMinimo { get; set; }
        public int? AniosAntiguedadMaximo { get; set; }
        public int? DiasVacaciones { get; set; }
        public int? EjercicioFiscal { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
