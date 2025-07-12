namespace eb4395u202312031.Inventory.Interfaces.REST.Resources;

public record ThingResource(int id, Guid serialNumber,
    string model, string operationMode, decimal maximumTemperatureThreshold,
    decimal miniumHumidityThreshold);
    