using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using eb4395u202312031.Inventory.Domain.Model.Aggregates;
using eb4395u202312031.Inventory.Domain.Model.ValueObjects;
using eb4395u202312031.Inventory.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Inventory.Infrastructure.Persistence.EFC.Repositories;

public class ThingRepository(AppDbContext context) : BaseRepository<Thing>(context), IThingRepository

{
    public async Task<Thing?> FindThingBySerialNumberAsync(Guid serialNumber)
    {
        return await Context.Set<Thing>().FirstOrDefaultAsync(sn => sn.SerialNumber.Identifier == serialNumber);
    }
}