using eb4395u202312031.Inventory.Domain.Model.Queries;
namespace eb4395u202312031.Inventory.Domain.Services;

/// <summary>
/// Defines query operations for retrieving Thing entities based on specified criteria.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IThingQueryService
{
    /// <summary>
    /// Handles the retrieval of all Thing entities in the system.
    /// </summary>
    /// <param name="query">The query object used to trigger the retrieval.</param>
    /// <returns>
    /// A task representing the asynchronous operation, which returns a collection of Thing entities.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<IEnumerable<Thing>> Handle(GetAllThingsQuery query);

    /// <summary>
    /// Handles the retrieval of a Thing entity by its serial number.
    /// </summary>
    /// <param name="query">The query containing the serial number of the Thing to retrieve.</param>
    /// <returns>
    /// A task representing the asynchronous operation, which returns the Thing entity if found; otherwise, null.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<Thing?> Handle(GetThingBySerialNumberQuery query);
}