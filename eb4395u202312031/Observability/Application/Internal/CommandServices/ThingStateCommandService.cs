using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventory.Interfaces.ACL;
using eb4395u202312031.Observability.Domain.Model.Aggregates;
using eb4395u202312031.Observability.Domain.Model.Commands;
using eb4395u202312031.Observability.Domain.Repositories;
using eb4395u202312031.Observability.Domain.Services;

namespace eb4395u202312031.Observability.Application.Internal.CommandServices;

/// <summary>
/// Handles the creation of ThingState entities, applying business validations and coordinating persistence.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ThingStateCommandService(IThingStateRepository repository, IUnitOfWork unitOfWork, IThingsContextFacade facade)
    : IThingStateCommandService
{
    /// <summary>
    /// Processes a command to create a new ThingState. Validates uniqueness and existence of related Thing entity.
    /// </summary>
    /// <param name="command">The command containing data required to create a ThingState.</param>
    /// <returns>
    /// A task representing the asynchronous operation. Returns the created ThingState if successful; otherwise, throws exception.
    /// </returns>
    /// <exception cref="Exception">
    /// Thrown if the ThingState already exists for the given serial number and timestamp collected at,
    /// or if the related Thing is not found.
    /// </exception>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<ThingState?> Handle(CreateThingStateCommand command)
    {
        var lastOpMode = await repository.FindLastOperationMode();

        if (await repository.ExistsByThingSerialNumberAndCollectedAt(command.ThingSerialNumber.Identifier,
                command.CollectedAt))
        {
            throw new Exception($"Thing state with serial number {command.ThingSerialNumber.Identifier} and collected at {command.CollectedAt} already exists.");
        }

        var thing = await facade.FetchThingBySerialNumberAsync(command.ThingSerialNumber.Identifier);
        if (thing == 0)
        {
            throw new Exception($"Thing with serial number {command.ThingSerialNumber.Identifier} not found.");
        }

        var ThingState = new ThingState(command);
        
        await repository.AddAsync(ThingState);
        await unitOfWork.CompleteAsync();

        return ThingState;
    }
}
