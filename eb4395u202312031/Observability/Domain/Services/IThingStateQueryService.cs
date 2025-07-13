using eb4395u202312031.Observability.Domain.Model.Queries;

namespace eb4395u202312031.Observability.Domain.Services;

/// <summary>
/// Defines the contract for handling queries related to ThingState entities in the Observability context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IThingStateQueryService
{
    /// <summary>
    /// Handles the retrieval of the most recent operation mode from ThingState records.
    /// </summary>
    /// <param name="query">The query requesting the last operation mode.</param>
    /// <returns>
    /// A task representing the asynchronous operation, returning the last recorded operation mode as an integer.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<int> Handle(GetLastOperationModeQuery query);
}