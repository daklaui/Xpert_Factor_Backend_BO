using CleanArc.Application.Common;
using CleanArc.Application.Features.ListVal.Queries.GetAllRecouvrement;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.ListVal;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/ListVal")]
public class ListValController:BaseController
{
    private readonly ISender _sender;

    public ListValController(ISender sender)
    {
        _sender = sender;
    }
    
    
    [HttpGet("GetAllRecouvrement")]
    public async Task<IActionResult> GetListOfRecouvrement([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllRecouvrementQuery(paginationParams));

        return base.OperationResult(query);
    }
}