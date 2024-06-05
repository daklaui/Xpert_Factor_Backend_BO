using CleanArc.Application.Common;
using CleanArc.Application.Features.Limite.Commands.AddLimiteCommand;
using CleanArc.Application.Features.Limite.Commands.ValidateLimiteCommand;
using CleanArc.Application.Features.Limite.Queries;
using CleanArc.Application.Features.Limite.Queries.checkExistingLimiteNoActif;
using CleanArc.Application.Features.Limite.Queries.GetAllListOfDemLimitNoActif;
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
    
    [HttpPut("ValidateLimite")]
    public async Task<IActionResult> ValidateLimite([FromBody] ValidateLimiteCommand model)
    {
        if (model == null)
        {
            return BadRequest("Invalid model");
        }
        var command = await _sender.Send(new ValidateLimiteCommand(model.REF_DEM_LIM));

        return base.OperationResult(command);
    }
    
    [HttpGet("GetAllLimite")]
    public async Task<IActionResult> GetAllLimite([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetListOfDemLimitQuery(paginationParams));

        return base.OperationResult(query);
    }
    
    [HttpGet("checkExistingLimiteNoActif/{REF_DEM_LIM,REF_CTR_DEM_LIM}")]
    public async Task<IActionResult> checkExistingLimiteNoActif(int REF_DEM_LIM, int REF_CTR_DEM_LIM)
    {
        var query = await _sender.Send(new CheckExistingLimiteNoActifQuery(REF_DEM_LIM,  REF_CTR_DEM_LIM));

        return base.OperationResult(query);
    }
    [HttpGet("GetAllListOfDemLimitNoActif")]
    public async Task<IActionResult> GetAllListOfDemLimitNoActif([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllListOfDemLimitNoActifQuery(paginationParams));

        return base.OperationResult(query);
    }

    
}