namespace eb4395u202312031.Observability.Interfaces.ACL;

public interface IThingStatesContextFacade
{
    Task<int> FindLastOperationMode();
}