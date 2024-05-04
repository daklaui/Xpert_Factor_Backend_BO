using CleanArc.Application.Common;
using CleanArc.Application.Features.Recouvrement.Commands;
using CleanArc.Application.Features.Recouvrement.Commands.UpdateRecouvrementCommand;
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
    [HttpPost("CreateNewRecouvrement")]
    public async Task<IActionResult> CreateNewRecouvrement(AddRecouvrementCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    
    [HttpGet("GetAllRecouvrements")]
    public async Task<IActionResult> GetAllRecouvrements([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllRecouvrementQuery(paginationParams));

        return base.OperationResult(query);
    }
    [HttpPut("UpdateRecouvrement")]
    public async Task<IActionResult> UpdateRecouvrement([FromBody] UpdateRecouvrementCommand model)
    {
        var command = await _sender.Send(model);
        return base.OperationResult(command);
    }
}