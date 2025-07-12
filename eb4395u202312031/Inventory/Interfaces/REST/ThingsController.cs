using System.Net.Mime;
using eb4395u202312031.Inventory.Domain.Model.Queries;
using eb4395u202312031.Inventory.Domain.Services;
using eb4395u202312031.Inventory.Interfaces.REST.Resources;
using eb4395u202312031.Inventory.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace eb4395u202312031.Inventory.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Available Thing Endpoints.")]
public class ThingsController(IThingCommandService thingCommandService, IThingQueryService thingQueryService)
    : ControllerBase
{
    [HttpGet]
    [SwaggerOperation("Get All Things", "Get all things", OperationId = "GetAllThings")]
    [SwaggerResponse(201, "The things were found and returned", typeof(IEnumerable<ThingResource>))]
    [SwaggerResponse(400, "The things were not found")]
    public async Task<IActionResult> GetAllThings()
    {
        var getAllThings = new GetAllThingsQuery();
        var things = await thingQueryService.Handle(getAllThings);
        var thingsResources = things.Select(ThingResourceFromEntityAssembler.ToResourceFromEntity);
        return StatusCode(201, thingsResources);

    }
    
    [HttpPost]
    [SwaggerOperation("Create Thing", "Create a new thing.", OperationId = "CreateThing")]
    [SwaggerResponse(201, "The thing was created.", typeof(ThingResource))]
    [SwaggerResponse(400, "The thing was not created.")]
    public async Task<IActionResult> CreateProfile(CreateThingResource resource)
    {
        var createThingCommand = CreateThingCommandFromResourceAssembler.ToCommandFromResource(resource);
        var thing = await thingCommandService.Handle(createThingCommand);
        if (thing is null) return BadRequest();
        var thingResource = ThingResourceFromEntityAssembler.ToResourceFromEntity(thing);
        return StatusCode(201, thingResource);    
    }
    
}