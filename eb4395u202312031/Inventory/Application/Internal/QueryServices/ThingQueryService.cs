using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventory.Domain.Model.Aggregates;
using eb4395u202312031.Inventory.Domain.Model.Queries;
using eb4395u202312031.Inventory.Domain.Repositories;
using eb4395u202312031.Inventory.Domain.Services;

namespace eb4395u202312031.Inventory.Application.Internal.QueryServices;

/// <summary>
/// Provides query operations to retrieve Thing entities from the repository based on specific criteria.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ThingQueryService(IThingRepository repository) : IThingQueryService
{
    /// <summary>
    /// Handles a query to retrieve all Thing entities from the repository.
    /// </summary>
    /// <param name="query">The query object that triggers the retrieval of all Things.</param>
    /// <returns>An asynchronous task that returns a list of all Things.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<IEnumerable<Thing>> Handle(GetAllThingsQuery query)
    {
        return await repository.ListAsync();
    }

    /// <summary>
    /// Handles a query to retrieve a Thing entity by its serial number.
    /// </summary>
    /// <param name="query">The query containing the serial number to search for.</param>
    /// <returns>An asynchronous task that returns the Thing if found; otherwise, null.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<Thing?> Handle(GetThingBySerialNumberQuery query)
    {
        return await repository.FindThingBySerialNumberAsync(query.SerialNumber);
    }
}