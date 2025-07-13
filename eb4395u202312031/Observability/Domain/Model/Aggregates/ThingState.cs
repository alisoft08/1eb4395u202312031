using eb4395u202312031.Observability.Domain.Model.Commands;
using eb4395u202312031.Observability.Domain.Model.ValueObjects;

namespace eb4395u202312031.Observability.Domain.Model.Aggregates;

/// <summary>
/// Represents the state of a Thing at a specific point in time, including environmental readings and operation mode.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public partial class ThingState
{
    /// <summary>
    /// Gets the internal identifier of the ThingState entity.
    /// </summary>
    public int Id { get; }

    /// <summary>
    /// Gets the serial number of the Thing associated with this state.
    /// </summary>
    public ThingSerialNumber ThingSerialNumber { get; protected set; }

    /// <summary>
    /// Gets or sets the current operation mode of the Thing.
    /// </summary>
    public int CurrentOperationMode { get; set; }

    /// <summary>
    /// Gets or sets the current temperature reading.
    /// </summary>
    public decimal CurrentTemperature { get; set; }

    /// <summary>
    /// Gets or sets the current humidity reading.
    /// </summary>
    public decimal CurrentHumidity { get; set; }

    /// <summary>
    /// Gets or sets the timestamp when the data was collected.
    /// </summary>
    public DateTime CollectedAt { get; set; }

    /// <summary>
    /// Initializes an empty instance of the <see cref="ThingState"/> class.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public ThingState() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ThingState"/> class with raw parameter values.
    /// </summary>
    /// <param name="thingSerialNumber">The serial number of the Thing.</param>
    /// <param name="currentOperationMode">The current operation mode (0 to 2).</param>
    /// <param name="currentTemperature">The current temperature reading.</param>
    /// <param name="currentHumidity">The current humidity reading.</param>
    /// <param name="collectedAt">The collectedAt datetime.</param>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public ThingState(ThingSerialNumber thingSerialNumber, int currentOperationMode, decimal currentTemperature, decimal currentHumidity, DateTime collectedAt)
    {
        ThingSerialNumber = thingSerialNumber;
        CurrentOperationMode = currentOperationMode;
        CurrentTemperature = currentTemperature;
        CurrentHumidity = currentHumidity;
        CollectedAt = collectedAt;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ThingState"/> class based on a command input.
    /// Includes validations for operation mode range and collected at.
    /// </summary>
    /// <param name="command">The command containing all data to create a ThingState.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when values are outside allowed ranges.</exception>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public ThingState(CreateThingStateCommand command)
    {
        ThingSerialNumber = command.ThingSerialNumber;

        if (command.CurrentOperationMode < 0 || command.CurrentOperationMode > 2)
        {
            throw new ArgumentOutOfRangeException(nameof(command.CurrentOperationMode),
                "CurrentOperationMode must be between 0 and 2.");
        }

        CurrentOperationMode = command.CurrentOperationMode;
        CurrentTemperature = command.CurrentTemperature;
        CurrentHumidity = command.CurrentHumidity;

        if (command.CollectedAt > DateTime.UtcNow)
        {
            throw new ArgumentOutOfRangeException(nameof(command.CollectedAt), "CollectedAt cannot be in the future.");
        }

        CollectedAt = command.CollectedAt;
    }
}
