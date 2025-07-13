using eb4395u202312031.Inventory.Domain.Model.Commands;
using eb4395u202312031.Inventory.Interfaces.REST.Resources;

namespace eb4395u202312031.Inventory.Interfaces.REST.Transform;

/// <summary>
/// Provides a method to convert a CreateThingResource into a CreateThingCommand.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class CreateThingCommandFromResourceAssembler
{
    /// <summary>
    /// Transforms a REST resource into a domain command for creating a Thing entity.
    /// </summary>
    /// <param name="resource">The input resource received from the API request.</param>
    /// <returns>A CreateThingCommand instance containing the mapped data from the resource.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public static CreateThingCommand ToCommandFromResource(CreateThingResource resource)
    {
        return new CreateThingCommand(
            resource.model, 
            resource.maximumTemperatureThreshold,
            resource.miniumHumidityThreshold);
    }
}