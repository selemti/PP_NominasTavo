using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Biometria
{
    public class DispositivoBiometricoDto
    {
        public string Id { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string NumeroSerie { get; set; } = string.Empty;
        public string IpAsignada { get; set; } = string.Empty;
        public int? TipoDispositivo { get; set; }
        public string CentroId { get; set; } = string.Empty;
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}