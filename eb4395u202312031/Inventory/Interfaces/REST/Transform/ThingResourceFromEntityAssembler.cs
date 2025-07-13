using eb4395u202312031.Inventory.Interfaces.REST.Resources;

namespace eb4395u202312031.Inventory.Interfaces.REST.Transform;

/// <summary>
/// Provides a method to transform a Thing entity from the domain layer into a REST resource representation.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class ThingResourceFromEntityAssembler
{
    /// <summary>
    /// Converts a Thing domain entity into a ThingResource suitable for API responses.
    /// </summary>
    /// <param name="entity">The Thing entity from the domain model.</param>
    /// <returns>A ThingResource object containing the mapped data.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public static ThingResource ToResourceFromEntity(Thing entity)
    {
        return new ThingResource(
            entity.Id,
            entity.SerialNumber.Identifier, 
            entity.Model,
            entity.OperationMode.ToString(),
            entity.MaximumTemperatureThreshold,
            entity.MiniumHumidityThreshold);
    }
}