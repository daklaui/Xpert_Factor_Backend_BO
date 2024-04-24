using CleanArc.Application.Common;
using CleanArc.Application.Features.TR_CP.Commands.AddTR_CPCommand;
using CleanArc.Application.Features.TR_CP.Commands.UpdateTR_CPCommand;
using CleanArc.Application.Features.TR_CP.Queries.GetAllTR_CP;
using CleanArc.Application.Features.TR_CP.Queries.GetById;

using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.TR_CP;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/TR_CP")]
//[Authorize]
public class TR_CPController : BaseController
{
    private readonly ISender _sender;

    public TR_CPController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("CreateNewTR_CP")]
    public async Task<IActionResult> CreateNewTR_CP(AddTR_CPCommand model)
    {
        var command = await _sender.Send(model);
        return base.OperationResult(command);
    }

    [HttpGet("GetAllTR_CP")]
    public async Task<IActionResult> GetAllTR_CP([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllTR_CPQuery(paginationParams));
        return base.OperationResult(query);
    }

    [HttpGet("GetTR_CPById/{id}")]
    public async Task<IActionResult> GetTR_CPById(int id)
    {
        var query = await _sender.Send(new GetByIdQuery(id));
        return base.OperationResult(query);
    }

    [HttpPut("UpdateTR_CP")]
    public async Task<IActionResult> UpdateTR_CP(UpdateTR_CPCommand command)
    {
        var result = await _sender.Send(command);
        return base.OperationResult(result);
    }
}
