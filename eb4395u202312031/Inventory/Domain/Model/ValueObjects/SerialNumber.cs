namespace eb4395u202312031.Inventory.Domain.Model.ValueObjects;

/// <summary>
/// Represents the unique serial number used to identify a Thing entity.
/// </summary>
/// <param name="Identifier">The globally unique identifier (GUID) associated with the Thing.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record SerialNumber(Guid Identifier)
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SerialNumber"/> record with a randomly generated GUID.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public SerialNumber() : this(Guid.NewGuid()) { }
}