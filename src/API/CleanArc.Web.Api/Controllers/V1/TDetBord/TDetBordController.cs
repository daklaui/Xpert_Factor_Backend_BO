using CleanArc.Application.Common;
using CleanArc.Application.Features.TDetBord.Commands.AddTDetBordCommand;
using CleanArc.Application.Features.TDetBord.Commands.DeleteTDetBordCommand;
using CleanArc.Application.Features.TDetBord.Commands.UpdateTDetBordCommand;
using CleanArc.Application.Features.TDetBord.Queries.GetAllTDetBord;
using CleanArc.Application.Features.TDetBord.Queries.GetById;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.TDetBord;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/TDetBord")]
public class TDetBordController : BaseController
{
    private readonly ISender _sender;

    public TDetBordController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("CreateNewTDetBord")]
    public async Task<IActionResult> CreateNewTDetBord(AddTDetBordCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    
    [HttpGet("GetAllTDetBord")]
    public async Task<IActionResult> GetAllTDetBord([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllTDetBordQuery(paginationParams));

        return base.OperationResult(query);
    }
    [HttpGet("GetTDetBordById/{id}")]
    public async Task<IActionResult> GetTDetBordById(string id)
    {
        var query = await _sender.Send(new GetByIdQuery(id));

        return base.OperationResult(query);
    }
    [HttpPut("UpdateTDetBord")]
    public async Task<IActionResult> UpdateTDetBord([FromBody] UpdateTDetBordCommand model)
    {
        var command = await _sender.Send(model);
        return base.OperationResult(command);
    }
    [HttpDelete("DeleteTDetBord/{id}")]
    public async Task<IActionResult> DeleteTDetBord(string id)
    {
        var command = await _sender.Send(new DeleteTDetBordCommand { TDetBordId = id });
        return base.OperationResult<bool>(command);

    }
}