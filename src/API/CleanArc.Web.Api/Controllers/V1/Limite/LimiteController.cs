using CleanArc.Application.Common;
using CleanArc.Application.Features.Limite.Commands.AddLimiteCommand;
using CleanArc.Application.Features.Limite.Commands.ValidateLimiteCommand;
using CleanArc.Application.Features.Limite.Queries;
using CleanArc.Application.Features.Limite.Queries.GetListOfDemLimit;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Limite;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Limite")]
//[Authorize]

public class LimiteController:BaseController
{
    private readonly ISender _sender;

    public LimiteController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("CreateNewLimite")]
    public async Task<IActionResult> CreateNewLimite(AddLimiteCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    [HttpGet("GetListOfDemLimitNoActif")]
    public async Task<IActionResult> GetListOfDemLimitNoActif([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new getListOfDemLimitNoActifQuery(paginationParams));

        return base.OperationResult(query);
    }
    
    [HttpPut("ValidateLimite/{id}")]
    public async Task<IActionResult> ValidateLimite(int id, ValidateLimiteCommand model)
    {
        if (model == null)
        {
            return BadRequest("Invalid model");
        }

        model.REF_DEM_LIM = id; 

        var commandResult = await _sender.Send(model);

        if (commandResult == null || !commandResult.IsSuccess)
        {
            return BadRequest("Failed to update Limite");
        }

        return Ok("Limite updated successfully");
    }
    [HttpGet("GetAllLimite")]
    public async Task<IActionResult> GetAllLimite([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetListOfDemLimitQuery(paginationParams));

        return base.OperationResult(query);
    }
    
}