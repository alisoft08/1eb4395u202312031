using eb4395u202312031.Inventory.Domain.Model.ValueObjects;

namespace eb4395u202312031.Inventory.Domain.Model.Queries;

public record GetThingBySerialNumberQuery(Guid SerialNumber);