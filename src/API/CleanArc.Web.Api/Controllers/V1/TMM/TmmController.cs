using CleanArc.Application.Features.TMM.Commands.AddTmmCommand;
using CleanArc.Application.Features.TMM.Queries.GetAllTmmQueries;
using CleanArc.Application.Features.TMM.Queries.GetTmmByIdQueries;

namespace CleanArc.Web.Api.Controllers.V1.TMM;
using CleanArc.Application.Common;

using CleanArc.Application.Features.Order.Commands;
using CleanArc.Application.Features.Order.Queries.GetUserOrders;
using CleanArc.WebFramework.BaseController;
using CleanArc.WebFramework.WebExtensions;
using Mediator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Tmm")]
//[Authorize]
public class TmmController :BaseController
{
    private readonly ISender _sender;

    public TmmController(ISender sender)
    {
        _sender = sender;
    }
    [HttpPost("CreateNewTmm")]
    public async Task<IActionResult> CreateNewTmm(AddTmmCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    [HttpGet("GetAllTmm")]
    public async Task<IActionResult> GetAllTmm([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllTmmQuery(paginationParams));

        return base.OperationResult(query);
    }
    
    [HttpGet("GetTmmById/{id}")]
    public async Task<IActionResult> GetTmmById(int id)
    {
        var query = await _sender.Send(new GetTmmByIdQuery(id));
        return base.OperationResult(query);
    }
    
}