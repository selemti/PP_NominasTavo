using PP_Nominas.Models.Catalogos.Organizacion;
using PP_Nominas.Dtos.Catalogos.Organizacion;

namespace PP_Nominas.Converters.Catalogos.Organizacion
{
    public static class EmpresaCentroTrabajoConverter
    {
        public static EmpresaCentroTrabajoDto ToDto(EmpresaCentroTrabajo model)
        {
            return new EmpresaCentroTrabajoDto
            {
                Id = model.Id,
                GrupoEmpresaId = model.GrupoEmpresaId,
                CentroTrabajoId = model.CentroTrabajoId,
                Vigente = model.Vigente,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static EmpresaCentroTrabajo ToModel(EmpresaCentroTrabajoDto dto)
        {
            return new EmpresaCentroTrabajo
            {
                Id = dto.Id,
                GrupoEmpresaId = dto.GrupoEmpresaId,
                CentroTrabajoId = dto.CentroTrabajoId,
                Vigente = dto.Vigente,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
