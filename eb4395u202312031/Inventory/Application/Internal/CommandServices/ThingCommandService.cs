using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventory.Domain.Model.Aggregates;
using eb4395u202312031.Inventory.Domain.Model.Commands;
using eb4395u202312031.Inventory.Domain.Repositories;
using eb4395u202312031.Inventory.Domain.Services;
using eb4395u202312031.Observability.Interfaces.ACL;
using Mysqlx.Crud;

namespace eb4395u202312031.Inventory.Application.Internal.CommandServices;

public class ThingCommandService(IThingRepository repository, IUnitOfWork unitOfWork, IThingStatesContextFacade facade) : IThingCommandService
{
    public async Task<Thing?> Handle(CreateThingCommand command)
    {
        
        
        var thing = new Thing(command);
        var opMode = await facade.FindLastOperationMode();
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