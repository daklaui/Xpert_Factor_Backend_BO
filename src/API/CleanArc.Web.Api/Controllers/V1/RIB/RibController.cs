using CleanArc.Application.Common;
using CleanArc.Application.Features.RIB.Commands.AddRibCommand;
using CleanArc.Application.Features.RIB.Commands.EditRibIndividuCommand;
using CleanArc.Application.Features.RIB.Queries.GetAllRibsByIndividuQueries;
using CleanArc.Application.Features.RIB.Queries.GetRibByRibValue;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CleanArc.Web.Api.Controllers.V1.RIB;
[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Rib")]
//[Authorize]
public class RibController:BaseController
{
    private readonly ISender  _sender;
    private readonly ILogger<RibController> _logger;
    public RibController(ISender sender, ILogger<RibController> logger)
    {
        _sender = sender;
        _logger = logger;
    }
    
    
    [HttpPost("CreateNewRib")]
    public async Task<IActionResult> CreateNewRib(AddRibCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }

    
    [HttpGet("GetAllRibsByIndividu")]
    public async Task<IActionResult> GetAllRibsByIndividu([FromQuery] PaginationParams paginationParams)
    {
        
            var query = new GetAllRibsByIndividuQuery(paginationParams);

            var result = await _sender.Send(query);
            return base.OperationResult(result);
        
       
    }
        
    
    
    [HttpPut("EditRibIndividu")]
    public async Task<IActionResult> UpdateIndividu( [FromBody] EditRibCommand model)
    {
        if (model == null)
        {
            return BadRequest("Invalid model");
        }

        try
        {
            var command = await _sender.Send(model);
            return base.OperationResult(command);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error updating rib.");
            return BadRequest("An error occurred while processing your request.");
        }
    }
    
    [HttpGet("GetRibByRib/{rib}")]
    public async Task<IActionResult> GetRibByRib(string rib)
    {
        try
        {
            var query = new GetRibByRibValueQuery(rib);
            var result = await _sender.Send(query);
            return OperationResult(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error fetching individual with ID: {rib}");
            return BadRequest("An error occurred while processing your request.");
        }
    }
    
    
}