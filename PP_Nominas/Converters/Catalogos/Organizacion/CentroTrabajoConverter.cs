using PP_Nominas.Models.Catalogos.Organizacion;
using PP_Nominas.Dtos.Catalogos.Organizacion;


namespace PP_Nominas.Converters.Catalogos.Organizacion
{
    public static class CentroTrabajoConverter
    {
        public static CentroTrabajoDto ToDto(CentroTrabajo model)
        {
            return new CentroTrabajoDto
            {
                Id = model.Id,
                TipoCentroTrabajo = model.TipoCentroTrabajo,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static CentroTrabajo ToModel(CentroTrabajoDto dto)
        {
            return new CentroTrabajo
            {
                Id = dto.Id,
                TipoCentroTrabajo = dto.TipoCentroTrabajo,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
