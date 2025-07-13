using eb4395u202312031.Observability.Domain.Model.Queries;
using eb4395u202312031.Observability.Domain.Services;
using eb4395u202312031.Observability.Interfaces.ACL;

namespace eb4395u202312031.Observability.Application.ACL;

/// <summary>
/// Concrete implementation of the IThingStatesContextFacade interface.
/// Provides access to the latest operation mode from ThingState data by querying the domain service.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ThingStatesContextFacade(IThingStateQueryService thingStateQueryService) : IThingStatesContextFacade
{
    /// <summary>
    /// Retrieves the most recently recorded operation mode from ThingState data.
    /// </summary>
    /// <returns> An integer representing the latest operation mode.</returns>
    /// <remarks> 
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<int> FetchLatestOperationMode()
    {
        var getLastOperationMode = new GetLastOperationModeQuery();
        var thingState = await thingStateQueryService.Handle(getLastOperationMode);
        return thingState;
    }
}