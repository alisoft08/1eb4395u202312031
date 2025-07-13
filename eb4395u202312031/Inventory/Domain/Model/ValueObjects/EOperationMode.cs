namespace eb4395u202312031.Inventory.Domain.Model.ValueObjects;

/// <summary>
/// Defines the available operation modes for a Thing based on different environmental conditions or scheduling.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public enum EOperationMode
{
    /// <summary>
    /// Operation is based on a predefined schedule.
    /// </summary>
    ScheduleDriven,

    /// <summary>
    /// Operation is triggered based on temperature readings.
    /// </summary>
    TemperatureDriven,

    /// <summary>
    /// Operation is triggered based on humidity readings.
    /// </summary>
    HumidityDriven
}