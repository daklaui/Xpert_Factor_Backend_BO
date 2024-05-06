using CleanArc.Application.Common;
using CleanArc.Application.Features.Financement.Commands.AddFinancementCommand;
using CleanArc.Application.Features.Financement.Commands.RejectFinancementCommand;
using CleanArc.Application.Features.Financement.Commands.UpdateFinancementCommand;
using CleanArc.Application.Features.Financement.Queries;
using CleanArc.WebFramework.BaseController;
using Microsoft.AspNetCore.Mvc;
using Mediator;

namespace CleanArc.Web.Api.Controllers.V1.Financement;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Financement")]
public class FinancementController:BaseController
{
    private readonly ISender _sender;

    public FinancementController(ISender sender)
    {
        _sender = sender;
    }
    
    
    
    [HttpGet("GetFundingByRefCTr/{id}")]
    public async Task<IActionResult> GetFundingByRefCTr(int id)
    {
        var query = await _sender.Send(new GetFundingByRefCtrQuery(id));

        return base.OperationResult(query);
    }
    
    [HttpPost("CreateNewFinancement")]
    public async Task<IActionResult> CreateNewFinancement(AddFinancementCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    
    [HttpPut("ValidateFinancement/{id}")]
    public async Task<IActionResult> ValidateFinancement(int id, ValidateFinanceCommand model)
    {
        if (model == null)
        {
            return BadRequest("Invalid model");
        }

        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }

    [HttpPut("RejectFinancement/{id}")]
    public async Task<IActionResult> RejectFinancement(int id, RejectFinanceCommand model)
    {
        if (model == null)
        {
            return BadRequest("Invalid model");
        }

        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }

    [HttpGet("GetAllFinancement")]
    public async Task<IActionResult> GetAllFinancement([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllFinancementQuery(paginationParams));

        return base.OperationResult(query);
    }
}