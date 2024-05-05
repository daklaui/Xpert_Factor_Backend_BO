using CleanArc.Application.Common;
using CleanArc.Application.Features.RecouvrementList.Queries.GetAllFacturesEchu;
using CleanArc.Application.Features.RecouvrementList.Queries.GetAllfacturesNonEchu;
using CleanArc.Application.Features.RecouvrementList.Queries.GetAllRecouvrement;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.RecouvrementList;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/RecouvrementList")]
//[Authorize]
public class RecouvrementListController:BaseController
{
    private readonly ISender _sender;


    public RecouvrementListController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpGet("GetAllRecouvrementFactures")]
    public async Task<IActionResult> GetListOfRecouvrementFactures([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllRecouvrementFacturesQuery(paginationParams));

        return base.OperationResult(query);
    }
    [HttpGet("GetAllFacturesEchu")]
    public async Task<IActionResult> GetListOfFacturesEchu([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllFacturesEchuQuery(paginationParams));

        return base.OperationResult(query);
    }
    [HttpGet("GetAllFacturesNonEchu")]
    public async Task<IActionResult> GetListOfFacturesNonEchu([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllFacturesNonEchuQuery(paginationParams));

        return base.OperationResult(query);
    }
}