using PP_Nominas.Dtos.Catalogos.Compensaciones;
using PP_Nominas.Models.Catalogos.Compensaciones;

namespace PP_Nominas.Converters.Catalogos.Compensaciones
{
    public static class TabuladorSalarialConverter
    {
        public static TabuladorSalarial ToModel(TabuladorSalarialDto dto)
        {
            if (dto == null) return null!;

            return new TabuladorSalarial
            {
                Id = dto.Id,
                PuestoId = dto.PuestoId,
                SalarioMinimo = dto.SalarioMinimo,
                SalarioMaximo = dto.SalarioMaximo,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }

        public static TabuladorSalarialDto ToDto(TabuladorSalarial model)
        {
            if (model == null) return null!;

            return new TabuladorSalarialDto
            {
                Id = model.Id,
                PuestoId = model.PuestoId,
                SalarioMinimo = model.SalarioMinimo,
                SalarioMaximo = model.SalarioMaximo,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }
    }
}
