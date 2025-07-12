using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventory.Domain.Model.Aggregates;
using eb4395u202312031.Inventory.Domain.Model.ValueObjects;

namespace eb4395u202312031.Inventory.Domain.Repositories;

public interface IThingRepository : IBaseRepository<Thing>
{
    Task<Thing?> FindThingBySerialNumberAsync(Guid SerialNumber);
}