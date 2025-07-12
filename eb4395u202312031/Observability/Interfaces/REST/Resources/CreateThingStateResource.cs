using eb4395u202312031.Observability.Domain.Model.ValueObjects;

namespace eb4395u202312031.Observability.Interfaces.REST.Resources;

public record CreateThingStateResource(Guid ThingSerialNumber, int CurrentOperationMode, decimal CurrentTemperature,
        decimal CurrentHumidity, DateTime CollectedAt);