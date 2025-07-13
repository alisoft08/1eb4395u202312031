using eb4395u202312031.Observability.Domain.Model.Queries;
using eb4395u202312031.Observability.Domain.Repositories;
using eb4395u202312031.Observability.Domain.Services;

namespace eb4395u202312031.Observability.Application.Internal.QueryServices;

/// <summary>
/// Provides query handling logic for ThingState-related data in the Observability context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ThingStateQueryService(IThingStateRepository thingStateRepository) : IThingStateQueryService
{
    /// <summary>
    /// Handles a query to retrieve the most recent operation mode from ThingState records.
    /// </summary>
    /// <param name="query">The query object requesting the last operation mode.</param>
    /// <returns>
    /// A task representing the asynchronous operation, returning the last recorded operation mode as an integer.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<int> Handle(GetLastOperationModeQuery query)
    {
        return await thingStateRepository.FindLastOperationMode();
    }
}