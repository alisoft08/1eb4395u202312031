using eb4395u202312031.Inventory.Domain.Model.Commands;

namespace eb4395u202312031.Inventory.Domain.Services;

/// <summary>
/// Defines the contract for handling commands related to the creation of Thing entities.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IThingCommandService
{
    /// <summary>
    /// Handles the creation of a Thing entity based on the provided command data.
    /// </summary>
    /// <param name="command">The command containing the data required to create a Thing.</param>
    /// <returns>
    /// A task representing the asynchronous operation, which returns the created Thing if successful;
    /// otherwise, null.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<Thing?> Handle(CreateThingCommand command);
}