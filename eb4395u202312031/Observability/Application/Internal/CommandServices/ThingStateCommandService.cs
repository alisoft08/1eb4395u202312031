using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventory.Interfaces.ACL;
using eb4395u202312031.Observability.Domain.Model.Aggregates;
using eb4395u202312031.Observability.Domain.Model.Commands;
using eb4395u202312031.Observability.Domain.Repositories;
using eb4395u202312031.Observability.Domain.Services;
namespace eb4395u202312031.Observability.Application.Internal.CommandServices;

public class ThingStateCommandService(IThingStateRepository repository, IUnitOfWork unitOfWork, IThingsContextFacade facade) : IThingStateCommandService
{
    public async Task<ThingState?> Handle(CreateThingStateCommand command)
    {
        
        // var thing = await thingFacadeRepository.FetchThingBySerialNumberAsync(command.ThingSerialNumber.Identifier);
        // if(thing == 0) 
        // {
        //     throw new Exception($"Thing with serial number {command.ThingSerialNumber} not found.");
        // }
        if (await repository.ExistsByThingSerialNumberAndCollectedAt(command.ThingSerialNumber.Identifier,
                command.CollectedAt))
        {
            throw new Exception($"Thing state with serial number {command.ThingSerialNumber.Identifier} and collected at {command.CollectedAt} already exists.");
        }
        var thing = await facade.FindThingBySerialNumberAsync(command.ThingSerialNumber.Identifier);
        if(thing == 0) 
        {
            throw new Exception($"Thing with serial number {command.ThingSerialNumber.Identifier} not found.");
        }
        
        var ThingState = new ThingState(command);
        /*try
        {*/

            await repository.AddAsync(ThingState);
            await unitOfWork.CompleteAsync();
            return ThingState;
        /*}
        catch (Exception ex)
        {
            return null;
        }*/
    }
}