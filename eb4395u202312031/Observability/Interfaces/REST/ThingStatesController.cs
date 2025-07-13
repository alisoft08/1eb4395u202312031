using System.Net.Mime;
using eb4395u202312031.Observability.Domain.Services;
using eb4395u202312031.Observability.Interfaces.REST.Resources;
using eb4395u202312031.Observability.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace eb4395u202312031.Observability.Interfaces.REST;

/// <summary>
/// Exposes RESTful endpoints for managing ThingState entities in the Observability context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Available Thing State Endpoints.")]
public class ThingStatesController(IThingStateCommandService ThingStateCommandService)
    : ControllerBase
{
    /// <summary>
    /// Creates a new ThingState entity based on the provided input resource.
    /// </summary>
    /// <param name="resource">The resource containing the data to create the ThingState.</param>
    /// <returns>
    /// A 201 Created response with the created ThingStateResource if successful; otherwise, 400 BadRequest.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    [HttpPost]
    [SwaggerOperation("Create ThingState", "Create a new ThingState.", OperationId = "CreateThingState")]
    [SwaggerResponse(201, "The ThingState was created.", typeof(ThingStateResource))]
    [SwaggerResponse(400, "The ThingState was not created.")]
    public async Task<IActionResult> CreateProfile(CreateThingStateResource resource)
    {
        var createThingStateCommand = CreateThingStateCommandFromResourceAssembler.ToCommandFromResource(resource);
        var ThingState = await ThingStateCommandService.Handle(createThingStateCommand);
        if (ThingState is null) return BadRequest();
        var ThingResource = ThingStateResourceFromEntityAssembler.ToResourceFromEntity(ThingState);
        return StatusCode(201, ThingResource);    
    }
}