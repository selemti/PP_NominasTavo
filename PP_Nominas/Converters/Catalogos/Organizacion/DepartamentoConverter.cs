using PP_Nominas.Models.Catalogos.Organizacion;
using PP_Nominas.Dtos.Catalogos.Organizacion;

namespace PP_Nominas.Converters.Catalogos.Organizacion
{
    public static class DepartamentoConverter
    {
        public static DepartamentoDto ToDto(Departamento model)
        {
            return new DepartamentoDto
            {
                Id = model.Id,
                ClaveDepartamento = model.ClaveDepartamento,
                NombreDepartamento = model.NombreDepartamento,
                DivisionId = model.DivisionId,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static Departamento ToModel(DepartamentoDto dto)
        {
            return new Departamento
            {
                Id = dto.Id,
                ClaveDepartamento = dto.ClaveDepartamento,
                NombreDepartamento = dto.NombreDepartamento,
                DivisionId = dto.DivisionId,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
