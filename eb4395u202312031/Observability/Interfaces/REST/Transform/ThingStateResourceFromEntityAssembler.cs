

using eb4395u202312031.Observability.Domain.Model.Aggregates;
using eb4395u202312031.Observability.Interfaces.REST.Resources;

namespace eb4395u202312031.Observability.Interfaces.REST.Transform;

public static class ThingStateResourceFromEntityAssembler
{

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