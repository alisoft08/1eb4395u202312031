namespace eb4395u202312031.Observability.Interfaces.REST.Resources;

public record ThingStateResource(int Id, Guid ThingSerialNumber, int CurrentOperationMode,
    decimal CurrentTemperature, decimal CurrentHumidity, string CollectedAt);