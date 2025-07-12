using eb4395u202312031.Inventory.Domain.Model.ValueObjects;
using eb4395u202312031.Observability.Domain.Model.Commands;
using eb4395u202312031.Observability.Domain.Model.ValueObjects;
using eb4395u202312031.Observability.Interfaces.REST.Resources;
namespace eb4395u202312031.Observability.Interfaces.REST.Transform;

public static class CreateThingStateCommandFromResourceAssembler
{
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