using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using eb4395u202312031.Observability.Domain.Model.Aggregates;
using eb4395u202312031.Observability.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Observability.Infrastructure.Persistence.EFC.Repositories;

/// <summary>
/// Repository implementation for the ThingState aggregate. Provides persistence operations for ThingState.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ThingStateRepository(AppDbContext context)
    : BaseRepository<ThingState>(context), IThingStateRepository
{
    /// <summary>
    /// Checks if a ThingState exists with the specified serial number and timestamp.
    /// </summary>
    /// <param name="thingSerialNumber">The unique identifier of the Thing.</param>
    /// <param name="collectedAt">The timestamp when the state was collected.</param>
    /// <returns>True if a ThingState exists with the same serial number and timestamp; otherwise, false.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<bool> ExistsByThingSerialNumberAndCollectedAt(Guid thingSerialNumber, DateTime collectedAt)
    {
        return await Context.Set<ThingState>()
            .AnyAsync(thingState =>
                thingState.ThingSerialNumber.Identifier == thingSerialNumber &&
                thingState.CollectedAt == collectedAt);
    }

    /// <summary>
    /// Retrieves the operation mode of the most recent ThingState based on the collection timestamp.
    /// </summary>
    /// <returns>The operation mode as an integer of the latest ThingState entry.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<int> FindLastOperationMode()
    {
        return await Context.Set<ThingState>()
            .OrderByDescending(ts => ts.CollectedAt)
            .Select(ts => ts.CurrentOperationMode)
            .FirstOrDefaultAsync();
    }
}
