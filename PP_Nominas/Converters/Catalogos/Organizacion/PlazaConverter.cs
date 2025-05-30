using PP_Nominas.Models.Catalogos.Organizacion;
using PP_Nominas.Dtos.Catalogos.Organizacion;

namespace PP_Nominas.Converters.Catalogos.Organizacion
{
    public static class PlazaConverter
    {
        public static PlazaDto ToDto(Plaza model) => new PlazaDto
        {
            Id = model.Id,
            ClavePlaza = model.ClavePlaza,
            NombrePlaza = model.NombrePlaza,
            PuestoId = model.PuestoId,
            DepartamentoId = model.DepartamentoId,
            EstatusPlaza = model.EstatusPlaza,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };

        public static Plaza ToModel(PlazaDto dto) => new Plaza
        {
            Id = dto.Id,
            ClavePlaza = dto.ClavePlaza,
            NombrePlaza = dto.NombrePlaza,
            PuestoId = dto.PuestoId,
            DepartamentoId = dto.DepartamentoId,
            EstatusPlaza = dto.EstatusPlaza,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }
}
