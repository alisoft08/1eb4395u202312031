using eb4395u202312031.Observability.Domain.Model.Aggregates;
using eb4395u202312031.Observability.Interfaces.REST.Resources;

namespace eb4395u202312031.Observability.Interfaces.REST.Transform;

/// <summary>
/// Provides a method to convert a ThingState domain entity into a ThingStateResource for API responses.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class ThingStateResourceFromEntityAssembler
{
    /// <summary>
    /// Converts a ThingState entity into its corresponding REST resource representation.
    /// </summary>
    /// <param name="entity">The ThingState entity from the domain model.</param>
    /// <returns>A ThingStateResource object containing the mapped values.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public static ThingStateResource ToResourceFromEntity(ThingState entity)
    {
        return new ThingStateResource(
            entity.Id,
            entity.ThingSerialNumber.Identifier,
            entity.CurrentOperationMode,
            entity.CurrentTemperature,
            entity.CurrentHumidity,
            entity.CollectedAt.ToString());
    }
}