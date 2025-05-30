using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Models.Catalogos.Shared;

/// <summary>Dirección postal de una persona o centro de trabajo.</summary>
public class Direccion
{
    /// <summary>Identificador único de la dirección.</summary>
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    /// <summary>Calle principal de la dirección.</summary>
    
    public string? Calle { get; set; }

    /// <summary>Número exterior del domicilio.</summary>
    public string? NumeroExterior { get; set; }

    /// <summary>Número interior del domicilio.</summary>
    public string? NumeroInterior { get; set; }

    /// <summary>Colonia, fraccionamiento o barrio.</summary>
    public string? Colonia { get; set; }

    /// <summary>Código Postal (5 dígitos).</summary>
    
    [RegularExpression(@"^\d{5}$")]
    public string? CodigoPostal { get; set; }

    /// <summary>Localidad o pueblo dentro del municipio.</summary>
    public string? Localidad { get; set; }

    /// <summary>Municipio o delegación.</summary>
    public string? Municipio { get; set; }

    /// <summary>Entidad federativa o estado (clave estándar SAT).</summary>
    
    public string? EntidadFederativa { get; set; }

    /// <summary>País de residencia (nombre o clave).</summary>
    
    public string? Pais { get; set; } = "México";

    /// <summary>¿Esta dirección es la principal?</summary>
    public bool Principal { get; set; } = true;

    /// <summary>Notas adicionales o instrucciones de entrega.</summary>
    public string? Observaciones { get; set; }

    /// <summary>Fecha de la última modificación del documento.</summary>
    [BsonElement("ultimaModificacion")]
    public DateTime FechaUltimaModificacion { get; set; }

    /// <summary>Identificador del usuario que realizó la última modificación.</summary>
    [BsonElement("usuarioUltimaModificacion")]
    public string? UsuarioUltimaModificacion { get; set; }
}
