using eb4395u202312031.Inventory.Domain.Model.Queries;
using eb4395u202312031.Inventory.Domain.Services;
using eb4395u202312031.Inventory.Interfaces.ACL;

namespace eb4395u202312031.Inventory.Application.ACL;

/// <summary>
/// Provides an abstraction layer to query Thing data from the domain using a service-based approach.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ThingsContextFacade(IThingQueryService thingQueryService) : IThingsContextFacade
{
    /// <summary>
    /// Fetch a Thing entity by its serial number and returns its internal identifier.
    /// </summary>
    /// <param name="serialNumber">The unique serial number of the Thing to be searched.</param>
    /// <returns>The identifier of the Thing if found; otherwise, 0.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<int> FetchThingBySerialNumberAsync(Guid serialNumber)
    {
        var getThingBySerialNumber = new GetThingBySerialNumberQuery(serialNumber);
        var thing = await thingQueryService.Handle(getThingBySerialNumber);
        return thing?.Id ?? 0;
    }
}