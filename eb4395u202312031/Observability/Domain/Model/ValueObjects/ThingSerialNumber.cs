namespace eb4395u202312031.Observability.Domain.Model.ValueObjects;

/// <summary>
/// Represents the unique serial number used to identify a Thing entity in the Observability context.
/// </summary>
/// <param name="Identifier">The globally unique identifier (GUID) associated with the ThingState.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record ThingSerialNumber(Guid Identifier)
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ThingSerialNumber"/> record with a randomly generated GUID.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public ThingSerialNumber() : this(Guid.NewGuid()) { }
}