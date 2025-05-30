using PP_Nominas.Models.Catalogos.Biometria;
using PP_Nominas.Dtos.Catalogos.Biometria;

namespace PP_Nominas.Converters.Catalogos.Biometria
{
    public static class DispositivoBiometricoConverter
    {
        public static DispositivoBiometricoDto ToDto(DispositivoBiometrico model)
        {
            return new DispositivoBiometricoDto
            {
                Id = model.Id ?? string.Empty,
                Modelo = model.Modelo ?? string.Empty,
                NumeroSerie = model.NumeroSerie ?? string.Empty,
                IpAsignada = model.IpAsignada ?? string.Empty,
                TipoDispositivo = model.TipoDispositivo,
                CentroId = model.CentroId ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static DispositivoBiometrico ToModel(DispositivoBiometricoDto dto)
        {
            return new DispositivoBiometrico
            {
                Id = dto.Id ?? string.Empty,
                Modelo = dto.Modelo ?? string.Empty,
                NumeroSerie = dto.NumeroSerie ?? string.Empty,
                IpAsignada = dto.IpAsignada ?? string.Empty,
                TipoDispositivo = dto.TipoDispositivo,
                CentroId = dto.CentroId ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
