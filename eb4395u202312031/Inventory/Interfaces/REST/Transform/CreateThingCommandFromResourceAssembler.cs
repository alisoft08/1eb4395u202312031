using eb4395u202312031.Inventory.Domain.Model.Commands;
using eb4395u202312031.Inventory.Interfaces.REST.Resources;

namespace eb4395u202312031.Inventory.Interfaces.REST.Transform;

public static class CreateThingCommandFromResourceAssembler
{
    public static CreateThingCommand ToCommandFromResource(CreateThingResource resource)
    {
        return new CreateThingCommand(
            resource.model, 
            resource.maximumTemperatureThreshold,
            resource.miniumHumidityThreshold);
            
            
    }
}