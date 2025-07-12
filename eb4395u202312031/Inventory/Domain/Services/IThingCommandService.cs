using eb4395u202312031.Inventory.Domain.Model.Aggregates;
using eb4395u202312031.Inventory.Domain.Model.Commands;
using Mysqlx.Crud;

namespace eb4395u202312031.Inventory.Domain.Services;

public interface IThingCommandService
{
    Task<Thing?> Handle(CreateThingCommand command);
    
}