using eb4395u202312031.Observability.Domain.Model.ValueObjects;

namespace eb4395u202312031.Observability.Domain.Model.Commands;

public record CreateThingStateCommand(ThingSerialNumber ThingSerialNumber, int CurrentOperationMode,
    decimal CurrentTemperature, decimal CurrentHumidity, DateTime CollectedAt);