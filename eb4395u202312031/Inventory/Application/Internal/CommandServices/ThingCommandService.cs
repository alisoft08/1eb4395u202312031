using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventory.Domain.Model.Aggregates;
using eb4395u202312031.Inventory.Domain.Model.Commands;
using eb4395u202312031.Inventory.Domain.Repositories;
using eb4395u202312031.Inventory.Domain.Services;

namespace eb4395u202312031.Inventory.Application.Internal.CommandServices;

public class ThingCommandService(IThingRepository repository, IUnitOfWork unitOfWork) : IThingCommandService
{
    public async Task<Thing?> Handle(CreateThingCommand command)
    {
        
        var thing = new Thing(command);
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