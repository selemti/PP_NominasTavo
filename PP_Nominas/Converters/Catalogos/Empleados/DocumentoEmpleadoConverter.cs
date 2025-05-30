using System;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class DocumentoEmpleadoConverter
    {
        public static DocumentoEmpleadoDto ToDto(DocumentoEmpleado model)
        {
            return new DocumentoEmpleadoDto
            {
                Id = model.Id ?? string.Empty,
                Tipo = model.Tipo ?? string.Empty,
                NombreArchivo = model.NombreArchivo ?? string.Empty,
                Validado = model.Validado,
                TipoDocumento = model.TipoDocumento ?? string.Empty,
                Descripcion = model.Descripcion ?? string.Empty,
                UrlArchivo = model.UrlArchivo ?? string.Empty,
                FechaEntrega = model.FechaEntrega,
                EsObligatorio = model.EsObligatorio,
                EstaVigente = model.EstaVigente,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static DocumentoEmpleado ToModel(DocumentoEmpleadoDto dto)
        {
            return new DocumentoEmpleado
            {
                Id = dto.Id ?? string.Empty,
                Tipo = dto.Tipo ?? string.Empty,
                NombreArchivo = dto.NombreArchivo ?? string.Empty,
                Validado = dto.Validado,
                TipoDocumento = dto.TipoDocumento ?? string.Empty,
                Descripcion = dto.Descripcion ?? string.Empty,
                UrlArchivo = dto.UrlArchivo ?? string.Empty,
                FechaEntrega = dto.FechaEntrega,
                EsObligatorio = dto.EsObligatorio,
                EstaVigente = dto.EstaVigente,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
