namespace eb4395u202312031.Inventory.Domain.Model.ValueObjects;

public record SerialNumber(Guid Identifier)
{
    public SerialNumber() : this(Guid.NewGuid()) { }
}