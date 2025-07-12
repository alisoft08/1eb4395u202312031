using eb4395u202312031.Inventory.Domain.Model.Commands;
using eb4395u202312031.Inventory.Domain.Model.ValueObjects;

namespace eb4395u202312031.Inventory.Domain.Model.Aggregates;

public partial class Thing
{
    public int Id { get; }
    public SerialNumber SerialNumber { get; private set; } = new();
    public string Model { get; set; }
    public EOperationMode OperationMode { get; set; } = 0;
    public decimal MaximumTemperatureThreshold { get; set; }
    public decimal MiniumHumidityThreshold { get; set; }

    
    public Thing(string model, decimal maximumTemperatureThreshold,
        decimal miniumHumidityThreshold)
    {
        
        Model = model;
        MaximumTemperatureThreshold = maximumTemperatureThreshold;
        MiniumHumidityThreshold = miniumHumidityThreshold;
    }

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

    public void UpdateOperationMode(int operationMode)
    {
        OperationMode = (EOperationMode)operationMode;
    }
}
    
    
