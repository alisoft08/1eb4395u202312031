namespace eb4395u202312031.Observability.Domain.Model.ValueObjects;

public record ThingSerialNumber(Guid Identifier)
{
    public ThingSerialNumber() : this(Guid.NewGuid()) { }
}