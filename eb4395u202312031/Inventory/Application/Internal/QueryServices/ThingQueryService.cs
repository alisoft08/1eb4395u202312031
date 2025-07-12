using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventory.Domain.Model.Aggregates;
using eb4395u202312031.Inventory.Domain.Model.Queries;
using eb4395u202312031.Inventory.Domain.Repositories;
using eb4395u202312031.Inventory.Domain.Services;

namespace eb4395u202312031.Inventory.Application.Internal.QueryServices;

public class ThingQueryService(IThingRepository repository) : IThingQueryService
{
    public async Task<IEnumerable<Thing>> Handle(GetAllThingsQuery query)
    {
        return await repository.ListAsync();
    }

    public async Task<Thing?> Handle(GetThingBySerialNumberQuery query)
    {
        return await repository.FindThingBySerialNumberAsync(query.SerialNumber);
    }
}