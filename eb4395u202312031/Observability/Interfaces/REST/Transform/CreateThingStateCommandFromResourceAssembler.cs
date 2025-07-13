using eb4395u202312031.Inventory.Domain.Model.ValueObjects;
using eb4395u202312031.Observability.Domain.Model.Commands;
using eb4395u202312031.Observability.Domain.Model.ValueObjects;
using eb4395u202312031.Observability.Interfaces.REST.Resources;

namespace eb4395u202312031.Observability.Interfaces.REST.Transform;

/// <summary>
/// Provides a method to convert a CreateThingStateResource into a CreateThingStateCommand.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class CreateThingStateCommandFromResourceAssembler
{
    /// <summary>
    /// Transforms a REST resource into a domain command for creating a ThingState entity.
    /// </summary>
    /// <param name="resource">The input resource received from the API request.</param>
    /// <returns>A CreateThingStateCommand instance containing the mapped data from the resource.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public static CreateThingStateCommand ToCommandFromResource(CreateThingStateResource resource)
    {
        return new CreateThingStateCommand(
            new ThingSerialNumber(resource.ThingSerialNumber),
            resource.CurrentOperationMode,
            resource.CurrentTemperature,
            resource.CurrentHumidity,
            resource.CollectedAt);
    }
}