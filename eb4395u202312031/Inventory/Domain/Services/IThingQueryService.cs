using eb4395u202312031.Inventory.Domain.Model.Aggregates;
using eb4395u202312031.Inventory.Domain.Model.Queries;

namespace eb4395u202312031.Inventory.Domain.Services;

public interface IThingQueryService
{
    Task <IEnumerable<Thing>> Handle(GetAllThingsQuery query);
    
    Task <Thing?> Handle(GetThingBySerialNumberQuery query);
    
}