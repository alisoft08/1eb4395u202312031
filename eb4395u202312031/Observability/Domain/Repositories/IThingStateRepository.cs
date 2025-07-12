using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Observability.Domain.Model.Aggregates;

namespace eb4395u202312031.Observability.Domain.Repositories;

public interface IThingStateRepository : IBaseRepository<ThingState>
{
    Task<bool> ExistsByThingSerialNumberAndCollectedAt(Guid thingSerialNumber, DateTime collectedAt);
    
    
}