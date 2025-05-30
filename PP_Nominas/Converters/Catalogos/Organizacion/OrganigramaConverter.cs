using PP_Nominas.Models.Catalogos.Organizacion;
using PP_Nominas.Dtos.Catalogos.Organizacion;

namespace PP_Nominas.Converters.Catalogos.Organizacion
{
    public static class OrganigramaConverter
    {
        public static OrganigramaDto ToDto(Organigrama model) => new OrganigramaDto
        {
            Id = model.Id,
            DivisionId = model.DivisionId,
            PuestoId = model.PuestoId,
            CentroCostoId = model.CentroCostoId,
            NodoPadreId = model.NodoPadreId,
            Nivel = model.Nivel,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };

        public static Organigrama ToModel(OrganigramaDto dto) => new Organigrama
        {
            Id = dto.Id,
            DivisionId = dto.DivisionId,
            PuestoId = dto.PuestoId,
            CentroCostoId = dto.CentroCostoId,
            NodoPadreId = dto.NodoPadreId,
            Nivel = dto.Nivel,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }
}
