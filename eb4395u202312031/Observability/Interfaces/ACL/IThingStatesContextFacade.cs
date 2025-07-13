namespace eb4395u202312031.Observability.Interfaces.ACL;

/// <summary>
/// Facade interface to provide access to ThingState context information from external bounded contexts.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IThingStatesContextFacade
{
    /// <summary>
    /// Fetches the latest recorded operation mode from ThingState data.
    /// </summary>
    /// <returns>The most recent operation mode as an integer.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<int> FetchLatestOperationMode();
}