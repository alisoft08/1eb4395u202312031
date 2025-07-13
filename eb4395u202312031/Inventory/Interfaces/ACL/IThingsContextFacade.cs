namespace eb4395u202312031.Inventory.Interfaces.ACL;

/// <summary>
/// Defines the contract for accessing external data related to Thing entities from another bounded context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IThingsContextFacade
{
    /// <summary>
    /// Fetches the internal identifier of a Thing entity by its serial number from an external context.
    /// </summary>
    /// <param name="serialNumber">The globally unique serial number of the Thing to fetch.</param>
    /// <returns>
    /// A task representing the asynchronous operation, returning the Thing ID if found; otherwise, 0.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<int> FetchThingBySerialNumberAsync(Guid serialNumber);
}