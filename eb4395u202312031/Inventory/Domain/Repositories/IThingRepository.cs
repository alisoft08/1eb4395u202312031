using eb4395u202312031.API.Shared.Domain.Repositories;
namespace eb4395u202312031.Inventory.Domain.Repositories;

/// <summary>
/// Defines a contract for Thing-specific data access operations in the inventory domain.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IThingRepository : IBaseRepository<Thing>
{
    /// <summary>
    /// Finds a Thing entity by its associated serial number.
    /// </summary>
    /// <param name="SerialNumber">The GUID representing the unique serial number of the Thing.</param>
    /// <returns>A task that represents the asynchronous operation, containing the Thing if found; otherwise, null.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<Thing?> FindThingBySerialNumberAsync(Guid SerialNumber);
}