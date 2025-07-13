namespace eb4395u202312031.Inventory.Interfaces.REST.Resources;

/// <summary>
/// Represents the data required to create a new Thing entity via the REST API.
/// </summary>
/// <param name="model">The model name of the Thing.</param>
/// <param name="maximumTemperatureThreshold">The maximum allowed temperature threshold for the Thing.</param>
/// <param name="miniumHumidityThreshold">The minimum allowed humidity threshold for the Thing.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record CreateThingResource(
    string model,
    decimal maximumTemperatureThreshold,
    decimal miniumHumidityThreshold);