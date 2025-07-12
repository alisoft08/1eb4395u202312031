using eb4395u202312031.Observability.Domain.Queries;

namespace eb4395u202312031.Observability.Domain.Services;

public interface IThingStateQueryService
{
    Task<int> Handle(GetLastOperationModeQuery query);
}