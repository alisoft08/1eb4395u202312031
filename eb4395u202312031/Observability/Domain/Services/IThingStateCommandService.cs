using eb4395u202312031.Observability.Domain.Model.Aggregates;
using eb4395u202312031.Observability.Domain.Model.Commands;
namespace eb4395u202312031.Observability.Domain.Services;

public interface IThingStateCommandService
{
    Task<ThingState?> Handle(CreateThingStateCommand command);
}