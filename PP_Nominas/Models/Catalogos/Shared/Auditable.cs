using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PP_Nominas.Models.Catalogos.Shared;

/// <summary>
/// Representa la clase Auditable.
/// </summary>
public partial class Auditable : INotifyPropertyChanged
{
    /// <summary>
    /// Obtiene o establece FechaCreacion.
    /// </summary>
    [Display(Name = "Fecha de creación del registro")]
    public IReadOnlyCollection<DateTime>?FechaCreacion { get; set; }
    /// <summary>
    /// Obtiene o establece FechaModificacion.
    /// </summary>

    /// <summary>
    /// Obtiene o establece UsuarioCreadorId.
    /// </summary>
    [Display(Name = "Usuario que creó el registro")]
    string UsuarioCreadorId { get; set; }
    /// <summary>
    /// Obtiene o establece UsuarioModificadorId.
    /// </summary>
    [Display(Name = "Usuario que modificó el registro")]
    string UsuarioModificadorId { get; set; }
    /// <summary>
    /// Fecha de la última modificación del documento.
    /// </summary>
    public DateTime FechaUltimaModificacion { get; set; }
    /// <summary>
    /// Identificador del usuario que realizó la última modificación.
    /// </summary>
    public string UsuarioUltimaModificacion { get; set; }
    public event PropertyChangedEventHandler? PropertyChanged;
}