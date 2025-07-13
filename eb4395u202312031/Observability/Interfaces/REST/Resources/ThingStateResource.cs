namespace eb4395u202312031.Observability.Interfaces.REST.Resources;

/// <summary>
/// Represents the data returned by the API for a ThingState entity, including environmental readings and metadata.
/// </summary>
/// <param name="Id">The unique identifier of the ThingState record.</param>
/// <param name="ThingSerialNumber">The serial number associated with the Thing.</param>
/// <param name="CurrentOperationMode">The current operation mode of the Thing at the time of data collection.</param>
/// <param name="CurrentTemperature">The temperature value recorded.</param>
/// <param name="CurrentHumidity">The humidity value recorded.</param>
/// <param name="CollectedAt">The timestamp of when the data was collected, formatted as a string.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record ThingStateResource(
    int Id,
    Guid ThingSerialNumber,
    int CurrentOperationMode,
    decimal CurrentTemperature,
    decimal CurrentHumidity,
    string CollectedAt);