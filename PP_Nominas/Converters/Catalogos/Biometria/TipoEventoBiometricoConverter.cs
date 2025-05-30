public static class TipoEventoBiometricoConverter
{
    public static TipoEventoBiometricoDto ToDto(TipoEventoBiometrico model)
    {
        if (model == null) return null!;

        return new TipoEventoBiometricoDto
        {
            Id = model.Id,
            NombreEvento = model.NombreEvento,
            DescripcionEvento = model.DescripcionEvento,
            Activo = model.Activo,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };
    }

    public static TipoEventoBiometrico ToModel(TipoEventoBiometricoDto dto)
    {
        if (dto == null) return null!;

        return new TipoEventoBiometrico
        {
            Id = dto.Id,
            NombreEvento = dto.NombreEvento,
            DescripcionEvento = dto.DescripcionEvento,
            Activo = dto.Activo,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }
}
