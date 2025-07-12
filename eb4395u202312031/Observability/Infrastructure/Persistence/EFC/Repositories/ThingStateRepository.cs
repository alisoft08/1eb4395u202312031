using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using eb4395u202312031.Observability.Domain.Model.Aggregates;
using eb4395u202312031.Observability.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Observability.Infrastructure.Persistence.EFC.Repositories;

public class ThingStateRepository(AppDbContext context) : BaseRepository<ThingState>(context), IThingStateRepository
{
    public async Task<bool> ExistsByThingSerialNumberAndCollectedAt(Guid thingSerialNumber, DateTime collectedAt)
    {
        return await Context.Set<ThingState>().AnyAsync(thingState => thingState.ThingSerialNumber.Identifier == thingSerialNumber && thingState.CollectedAt == collectedAt);
    }

    public async Task<int> FindLastOperationMode()
    {
        // var maxDate = await Context.Set<ThingState>().MaxAsync(ts => ts.CollectedAt);
        //
        // return await Context.Set<ThingState>()
        //     .Where(ts => ts.CollectedAt == maxDate)
        //     .Select(ts => ts.CurrentOperationMode)
        //     .FirstOrDefaultAsync();
        
        return await Context.Set<ThingState>()
            .OrderByDescending(ts => ts.CollectedAt)
            .Select(ts => ts.CurrentOperationMode)
            .FirstOrDefaultAsync();
        
    }
}