using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Shared;

/// <summary>Datos generales de una persona.</summary>
public class Persona
{
    /// <summary>Identificador único de la persona.</summary>
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    /// <summary>Nombre(s) de la persona.</summary>
    
    public string? Nombre { get; set; }

    /// <summary>Apellido paterno.</summary>
    
    public string? ApellidoPaterno { get; set; }

    /// <summary>Apellido materno.</summary>
    public string? ApellidoMaterno { get; set; }

    /// <summary>Nombre completo de la persona (calculado).</summary>
    public string? NombreCompleto => $"{Nombre} {ApellidoPaterno} {ApellidoMaterno}".Trim();

    /// <summary>Fecha de nacimiento.</summary>
    
    public DateTime FechaNacimiento { get; set; }

    /// <summary>CURP oficial.</summary>
    
    [StringLength(18, MinimumLength = 18)]
    public string? Curp { get; set; }

    /// <summary>RFC oficial.</summary>
    
    [StringLength(13)]
    public string? Rfc { get; set; }

    /// <summary>Sexo (según INEGI/SAT).</summary>
    
    public SexoEnum Sexo { get; set; }

    /// <summary>Estado civil actual.</summary>
    public EstadoCivilEnum? EstadoCivil { get; set; }

    /// <summary>Tipo de sangre (sistema RH).</summary>
    public TipoSangreEnum? TipoSangre { get; set; }
    /// <summary>Correo electrónico personal.</summary>
    [EmailAddress]
    public string? CorreoPersonal { get; set; }

    /// <summary>Nacionalidad oficial.</summary>
    public string? Nacionalidad { get; set; }

    /// <summary>Nivel de estudios (último grado).</summary>
    public NivelEstudioEnum? NivelEstudio { get; set; }

    /// <summary>Lista de teléfonos de contacto.</summary>
    public List<Telefono> Telefonos { get; set; } = new();

    /// <summary>Lista de direcciones registradas.</summary>
    public Direccion? Direccion { get; set; } = new();

    /// <summary>Fecha de última modificación.</summary>
    public DateTime FechaUltimaModificacion { get; set; }

    /// <summary>Usuario que realizó la última modificación.</summary>
    public string? UsuarioUltimaModificacion { get; set; }
}
