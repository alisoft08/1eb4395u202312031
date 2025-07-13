namespace eb4395u202312031.Inventory.Interfaces.REST.Resources;

/// <summary>
/// Represents the data returned by the API for a Thing entity, including identifiers, configuration, and thresholds.
/// </summary>
/// <param name="id">The internal identifier of the Thing.</param>
/// <param name="serialNumber">The globally unique serial number of the Thing.</param>
/// <param name="model">The model name of the Thing.</param>
/// <param name="operationMode">The current operation mode of the Thing, as a string.</param>
/// <param name="maximumTemperatureThreshold">The maximum temperature threshold configured for the Thing.</param>
/// <param name="miniumHumidityThreshold">The minimum humidity threshold configured for the Thing.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record ThingResource(
    int id,
    Guid serialNumber,
    string model,
    string operationMode,
    decimal maximumTemperatureThreshold,
    decimal miniumHumidityThreshold);