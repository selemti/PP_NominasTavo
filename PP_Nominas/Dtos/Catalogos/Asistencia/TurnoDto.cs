namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class TurnoDto
    {
        public string Id { get; set; } = string.Empty;
        public string NombreTurno { get; set; } = string.Empty;
        public string HoraEntrada { get; set; } = string.Empty;
        public string HoraSalida { get; set; } = string.Empty;
        public int? TipoTurno { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
