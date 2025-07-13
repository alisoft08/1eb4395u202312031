using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using eb4395u202312031.Inventory.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Inventory.Infrastructure.Persistence.EFC.Repositories;

/// <summary>
/// Provides database access methods for the Thing aggregate using Entity Framework Core.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ThingRepository(AppDbContext context) : BaseRepository<Thing>(context), IThingRepository
{
    /// <summary>
    /// Finds a Thing entity by its serial number.
    /// </summary>
    /// <param name="serialNumber">The GUID representing the unique serial number of the Thing.</param>
    /// <returns>
    /// A task representing the asynchronous operation, which returns the Thing if found; otherwise, null.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<Thing?> FindThingBySerialNumberAsync(Guid serialNumber)
    {
        return await Context.Set<Thing>().FirstOrDefaultAsync(sn => sn.SerialNumber.Identifier == serialNumber);
    }
}