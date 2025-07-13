using eb4395u202312031.Inventory.Domain.Model.Commands;
using eb4395u202312031.Inventory.Domain.Model.ValueObjects;

/// <summary>
/// Represents a Thing aggregate root in the Inventory domain.
/// </summary>
/// <remarks>Alison Jimena Arrieta Quispe</remarks>
public partial class Thing
{
    /// <summary>
    /// Gets the unique identifier for the Thing.
    /// </summary>
    public int Id { get; }

    /// <summary>
    /// Gets or sets the serial number of the Thing.
    /// </summary>
    public SerialNumber SerialNumber { get; private set; } = new();

    /// <summary>
    /// Gets or sets the model name of the Thing.
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Gets or sets the current operation mode of the Thing.
    /// </summary>
    public EOperationMode OperationMode { get; set; } = 0;

    /// <summary>
    /// Gets or sets the maximum temperature threshold for the Thing.
    /// </summary>
    public decimal MaximumTemperatureThreshold { get; set; }

    /// <summary>
    /// Gets or sets the minimum humidity threshold for the Thing.
    /// </summary>
    public decimal MiniumHumidityThreshold { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Thing"/> class with the specified model and thresholds.
    /// </summary>
    /// <param name="model">The model name of the Thing.</param>
    /// <param name="maximumTemperatureThreshold">The maximum temperature threshold.</param>
    /// <param name="miniumHumidityThreshold">The minimum humidity threshold.</param>
    /// <remarks>Alison Jimena Arrieta Quispe</remarks>
    public Thing(string model, decimal maximumTemperatureThreshold,
        decimal miniumHumidityThreshold)
    {
        Model = model;
        MaximumTemperatureThreshold = maximumTemperatureThreshold;
        MiniumHumidityThreshold = miniumHumidityThreshold;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Thing"/> class using a create command.
    /// </summary>
    /// <param name="command">The command containing Thing creation data.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when temperature or humidity thresholds are out of valid range.
    /// </exception>
    /// <remarks>Alison Jimena Arrieta Quispe</remarks>
    public Thing(CreateThingCommand command)
    {
        Model = command.model;
        if (command.maximumTemperatureThreshold < -40.78m || command.maximumTemperatureThreshold > 85.00m)
        {
            throw new ArgumentOutOfRangeException(nameof(command.maximumTemperatureThreshold),
                "Temperature must be between -40.00 and 85.00 degrees.");
        }

        MaximumTemperatureThreshold = command.maximumTemperatureThreshold;

        if(command.miniumHumidityThreshold < 0.00m || command.miniumHumidityThreshold > 100.00m)
        {
            throw new ArgumentOutOfRangeException(nameof(command.miniumHumidityThreshold),
                "Humidity must be between 0.00 and 100.00 percent.");
        }

        MiniumHumidityThreshold = command.miniumHumidityThreshold;
    }

    /// <summary>
    /// Updates the operation mode of the Thing.
    /// </summary>
    /// <param name="operationMode">The new operation mode as an integer.</param>
    /// <remarks>Alison Jimena Arrieta Quispe</remarks>
    public void UpdateOperationMode(int operationMode)
    {
        OperationMode = (EOperationMode)operationMode;
    }
}