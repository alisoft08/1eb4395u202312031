using eb4395u202312031.Observability.Domain.Model.ValueObjects;

namespace eb4395u202312031.Observability.Interfaces.REST.Resources;

/// <summary>
/// Represents the data required to create a new ThingState entity via the API.
/// </summary>
/// <param name="ThingSerialNumber">The unique serial number of the Thing to which the state belongs.</param>
/// <param name="CurrentOperationMode">The current operation mode of the Thing (as an integer).</param>
/// <param name="CurrentTemperature">The temperature value recorded at the time of data collection.</param>
/// <param name="CurrentHumidity">The humidity value recorded at the time of data collection.</param>
/// <param name="CollectedAt">The timestamp indicating when the data was collected.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record CreateThingStateResource(
    Guid ThingSerialNumber,
    int CurrentOperationMode,
    decimal CurrentTemperature,
    decimal CurrentHumidity,
    DateTime CollectedAt);