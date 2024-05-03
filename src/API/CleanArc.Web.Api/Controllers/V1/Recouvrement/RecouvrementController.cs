using CleanArc.Application.Common;
using CleanArc.Application.Features.Recouvrement.Queries.GetAllRecouvrements;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Recouvrement;
[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Recouvrement")]
public class RecouvrementController: BaseController
{
    private readonly ISender _sender;

    public RecouvrementController(ISender sender)
    {
        _sender = sender;
    }
    [HttpGet("GetAllRecouvrements")]
    public async Task<IActionResult> GetAllRecouvrements([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllRecouvrementQuery(paginationParams));

        return base.OperationResult(query);
    }
}