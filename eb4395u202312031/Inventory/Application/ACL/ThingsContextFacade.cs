using eb4395u202312031.Inventory.Domain.Model.Queries;
using eb4395u202312031.Inventory.Domain.Services;
using eb4395u202312031.Inventory.Interfaces.ACL;

namespace eb4395u202312031.Inventory.Application.ACL;

public class ThingsContextFacade(IThingQueryService thingQueryService) : IThingsContextFacade
{
    
    
    public async Task<int> FindThingBySerialNumberAsync(Guid serialNumber)
    {
        var getThingBySerialNumber = new GetThingBySerialNumberQuery(serialNumber);
        var thing = await thingQueryService.Handle(getThingBySerialNumber);
        return thing?.Id ?? 0;
    }
    
    
}