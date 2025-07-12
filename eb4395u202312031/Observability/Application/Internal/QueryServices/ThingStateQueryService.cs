using eb4395u202312031.Observability.Domain.Queries;
using eb4395u202312031.Observability.Domain.Repositories;
using eb4395u202312031.Observability.Domain.Services;

namespace eb4395u202312031.Observability.Application.Internal.QueryServices;

public class ThingStateQueryService(IThingStateRepository thingStateRepository) : IThingStateQueryService
{
    public async Task<int> Handle(GetLastOperationModeQuery query)
    {
        return await thingStateRepository.FindLastOperationMode();
    }
}