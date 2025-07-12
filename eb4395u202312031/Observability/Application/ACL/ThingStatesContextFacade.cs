using eb4395u202312031.Observability.Domain.Queries;
using eb4395u202312031.Observability.Domain.Services;
using eb4395u202312031.Observability.Interfaces.ACL;

namespace eb4395u202312031.Observability.Application.ACL;

public class ThingStatesContextFacade(IThingStateQueryService thingStateQueryService): IThingStatesContextFacade
{
    public async Task<int> FindLastOperationMode()
    {
        var getLastOperationMode = new GetLastOperationModeQuery();
        var thingState = await thingStateQueryService.Handle(getLastOperationMode);
        return thingState;

    }
}