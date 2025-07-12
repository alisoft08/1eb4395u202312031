namespace eb4395u202312031.Inventory.Interfaces.REST.Resources;

public record CreateThingResource(string model, 
    decimal maximumTemperatureThreshold, decimal miniumHumidityThreshold);