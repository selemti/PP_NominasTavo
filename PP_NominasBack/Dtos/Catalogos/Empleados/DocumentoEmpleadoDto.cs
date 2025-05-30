using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>DTO que representa un documento entregado por el empleado.</summary>
    public class DocumentoEmpleadoDto
    {
        /// <summary>ID del documento.</summary>
        
        [Display(Name = "ID del Documento")]
        public string? Id { get; set; }

        /// <summary>ID del tipo de documento, ligado a TipoArchivoEmpleado.</summary>

        public string? EmpleadoId { get; set; }

        
        [Display(Name = "Tipo de Documento")]
        public string? TipoId { get; set; } // Referencia a TipoArchivoEmpleado

        /// <summary>Nombre del archivo entregado.</summary>
        
        [Display(Name = "Nombre del Archivo")]
        public string? NombreArchivo { get; set; }

        /// <summary>Ruta o URL donde está almacenado el archivo.</summary>
        
        [Display(Name = "Ruta o URL del Documento")]
        public string? UrlArchivo { get; set; }

        /// <summary>Fecha de entrega del documento.</summary>
        [Display(Name = "Fecha de Entrega")]
        public DateTime FechaEntrega { get; set; } = DateTime.Now;

        /// <summary>Bandera para indicar si el documento fue validado.</summary>
        [Display(Name = "Validado")]
        public bool Validado { get; set; } = false;

        /// <summary>Usuario que modificó por última vez este documento.</summary>
        
        [Display(Name = "Usuario que Modificó")]
        public string? UsuarioUltimaModificacion { get; set; }
    }
}
