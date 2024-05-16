using CleanArc.Application.Common;
using CleanArc.Application.Features.Litige.Commands.Add;
using CleanArc.Application.Features.Litige.Commands.AddLitige;
using CleanArc.Application.Features.Litige.Queries.GetAllRapportFacturesEnLitige;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Litige;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Litige")]
public class LitigeController : BaseController
{
    private readonly ISender _sender;

    public LitigeController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("CreateNewLitige")]
    public async Task<IActionResult> CreateNewLitige(AddLitigesCommand model)
    {

        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    [HttpPost("CreateLitige")]
    public async Task<IActionResult> CreateLitige(AddCommand model)
    {

        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    [HttpGet("GetListRapportFacturesEnLitige")]
    public async Task<IActionResult> GetListRapportFacturesEnLitige([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllRapportFacturesEnLitigeQuery(paginationParams));

        return base.OperationResult(query);
    }
}