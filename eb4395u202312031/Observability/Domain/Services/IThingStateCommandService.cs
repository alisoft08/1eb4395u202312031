using eb4395u202312031.Observability.Domain.Model.Aggregates;
using eb4395u202312031.Observability.Domain.Model.Commands;

namespace eb4395u202312031.Observability.Domain.Services;

/// <summary>
/// Defines the contract for handling commands related to the creation of ThingState entities.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IThingStateCommandService
{
    /// <summary>
    /// Processes a command to create a new ThingState entity.
    /// </summary>
    /// <param name="command">The command containing the data required to create the ThingState.</param>
    /// <returns>
    /// A task representing the asynchronous operation, returning the created ThingState if successful; otherwise, null.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<ThingState?> Handle(CreateThingStateCommand command);
}