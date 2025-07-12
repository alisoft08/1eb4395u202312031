using eb4395u202312031.Observability.Domain.Model.Commands;
using eb4395u202312031.Observability.Domain.Model.ValueObjects;

namespace eb4395u202312031.Observability.Domain.Model.Aggregates;

public class ThingState
{
    public int Id { get; }
    
    public ThingSerialNumber ThingSerialNumber { get; protected set; }
    
    public int CurrentOperationMode { get; set; }
    
    public decimal CurrentTemperature { get; set; }
    
    public decimal CurrentHumidity { get; set; }
    
    public DateTime CollectedAt { get; set; }

    
    public ThingState() { }
    public ThingState(ThingSerialNumber thingSerialNumber, int currentOperationMode, decimal currentTemperature, decimal currentHumidity, DateTime collectedAt)
    {
        ThingSerialNumber = thingSerialNumber;
        CurrentOperationMode = currentOperationMode;
        CurrentTemperature = currentTemperature;
        CurrentHumidity = currentHumidity;
        CollectedAt = collectedAt;
    }

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
        if(command.CollectedAt > DateTime.UtcNow)
        {
            throw new ArgumentOutOfRangeException(nameof(command.CollectedAt), "CollectedAt cannot be in the future.");
        }
        CollectedAt = command.CollectedAt;
    }
    
    
}