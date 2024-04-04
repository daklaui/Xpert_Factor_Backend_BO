using CleanArc.Application.Common;
using CleanArc.Application.Features.Bordereaux.Commands.AddBordereauxCommand;
using CleanArc.Application.Features.Bordereaux.Commands.DeleteBordereauxCommand;
using CleanArc.Application.Features.Bordereaux.Queries.GetAllBordereaux;
using CleanArc.Application.Features.Bordereaux.Queries.GetById;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Bordereaux;
[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Bordereaux")]
public class BordereauxController : BaseController
{
    private readonly ISender _sender;

    public BordereauxController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("CreateNewBordereaux")]
    public async Task<IActionResult> CreateNewBordereaux(AddBordereauxCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    
    [HttpGet("GetAllBordereaux")]
    public async Task<IActionResult> GetAllBordereaux([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllBordereauxQuery(paginationParams));

        return base.OperationResult(query);
    }
    
    [HttpGet("GetBordereauxById/{id}")]
    public async Task<IActionResult> GetBordereauxById(string id)
    {
        var query = await _sender.Send(new GetByIdQuery(id));

        return base.OperationResult(query);
    }
    
    [HttpDelete("DeleteBordereaux/{id}")]
    public async Task<IActionResult> DeleteBordereaux(string id)
    {
        var command = await _sender.Send(new DeleteBordereauxCommand { BordereauId = id });
        return base.OperationResult<bool>(command);

    }
}