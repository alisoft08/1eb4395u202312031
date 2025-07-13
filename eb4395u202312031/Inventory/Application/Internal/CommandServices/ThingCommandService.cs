using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventory.Domain.Model.Commands;
using eb4395u202312031.Inventory.Domain.Repositories;
using eb4395u202312031.Inventory.Domain.Services;
using eb4395u202312031.Observability.Interfaces.ACL;

namespace eb4395u202312031.Inventory.Application.Internal.CommandServices;

/// <summary>
/// Handles the creation of Thing entities by applying business rules and coordinating data persistence.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ThingCommandService(IThingRepository repository, IUnitOfWork unitOfWork, IThingStatesContextFacade facade) : IThingCommandService
{
    /// <summary>
    /// Processes a command to create a new Thing, assigning the latest current operation mode and saving it to the repository.
    /// </summary>
    /// <param name="command">The command containing the required data to create the Thing.</param>
    /// <returns>The newly created Thing if successful; otherwise, null.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<Thing?> Handle(CreateThingCommand command)
    {
        var thing = new Thing(command);
        var opMode = await facade.FetchLatestOperationMode();
        thing.UpdateOperationMode(opMode);

        try
        {
            await repository.AddAsync(thing);
            await unitOfWork.CompleteAsync();
            return thing;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}