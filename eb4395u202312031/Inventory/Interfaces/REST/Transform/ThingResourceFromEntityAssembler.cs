using eb4395u202312031.Inventory.Domain.Model.Aggregates;
using eb4395u202312031.Inventory.Interfaces.REST.Resources;

namespace eb4395u202312031.Inventory.Interfaces.REST.Transform;

public static class ThingResourceFromEntityAssembler
{

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