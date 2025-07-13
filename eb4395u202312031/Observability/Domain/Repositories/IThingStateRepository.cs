using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Observability.Domain.Model.Aggregates;

namespace eb4395u202312031.Observability.Domain.Repositories;

/// <summary>
/// Defines custom data access operations for the ThingState aggregate in the Observability context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IThingStateRepository : IBaseRepository<ThingState>
{
    /// <summary>
    /// Checks whether a ThingState already exists for the given serial number and timestamp.
    /// </summary>
    /// <param name="thingSerialNumber">The unique identifier of the Thing.</param>
    /// <param name="collectedAt">The timestamp of the data collection.</param>
    /// <returns>
    /// A task representing the asynchronous operation, returning true if a matching ThingState exists; otherwise, false.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<bool> ExistsByThingSerialNumberAndCollectedAt(Guid thingSerialNumber, DateTime collectedAt);

    /// <summary>
    /// Retrieves the last recorded operation mode from the most recent ThingState.
    /// </summary>
    /// <returns>
    /// A task representing the asynchronous operation, returning the latest operation mode as an integer.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<int> FindLastOperationMode();
}