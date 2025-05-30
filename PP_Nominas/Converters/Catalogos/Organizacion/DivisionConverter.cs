using PP_Nominas.Models.Catalogos.Organizacion;
using PP_Nominas.Dtos.Catalogos.Organizacion;

namespace PP_Nominas.Converters.Catalogos.Organizacion
{
    public static class DivisionConverter
    {
        public static DivisionDto ToDto(Division model)
        {
            return new DivisionDto
            {
                Id = model.Id,
                GrupoEmpresaId = model.GrupoEmpresaId,
                ClaveDivision = model.ClaveDivision,
                NombreDivision = model.NombreDivision,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static Division ToModel(DivisionDto dto)
        {
            return new Division
            {
                Id = dto.Id,
                GrupoEmpresaId = dto.GrupoEmpresaId,
                ClaveDivision = dto.ClaveDivision,
                NombreDivision = dto.NombreDivision,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
