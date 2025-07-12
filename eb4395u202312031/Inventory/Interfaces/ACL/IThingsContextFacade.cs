namespace eb4395u202312031.Inventory.Interfaces.ACL;

public interface IThingsContextFacade
{

    Task<int> FindThingBySerialNumberAsync(Guid serialNumber);

}