namespace eb4395u202312031.Inventory.Domain.Model.Commands;

public record CreateThingCommand(string model, decimal maximumTemperatureThreshold,
    decimal miniumHumidityThreshold);