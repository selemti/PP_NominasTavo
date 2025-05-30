using PP_Nominas.Models.Catalogos.Incidencias;
using PP_Nominas.Dtos.Catalogos.Incidencias;

public static class TipoIncidenciaConverter
{
    public static TipoIncidenciaDto ToDto(TipoIncidencia model)
    {
        if (model == null) return null!; // O lanzar excepción, según convenga

        return new TipoIncidenciaDto
        {
            Id = model.Id,
            NombreTipoIncidencia = model.NombreTipoIncidencia,
            DescripcionTipoIncidencia = model.DescripcionTipoIncidencia,
            RequiereJustificante = model.RequiereJustificante,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion,
        };
    }

    public static TipoIncidencia ToModel(TipoIncidenciaDto dto)
    {
        if (dto == null) return null!; // O lanzar excepción, según convenga

        var model = new TipoIncidencia
        {
            Id = dto.Id,
            NombreTipoIncidencia = dto.NombreTipoIncidencia,
            DescripcionTipoIncidencia = dto.DescripcionTipoIncidencia,
            RequiereJustificante = dto.RequiereJustificante,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion,
        };

        return model;
    }
}
