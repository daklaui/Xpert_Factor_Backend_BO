using CleanArc.Application.Common;
using CleanArc.Application.Features.TMM.Commands.AddTmmCommand;
using CleanArc.Application.Features.TMM.Commands.UpdateTmmCommand;
using CleanArc.Application.Features.TMM.Queries.GetAllTmmQuerie;
using CleanArc.Application.Features.TMM.Queries.GetTmmByIdQuerie;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.TMM;
[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Tmm")]
public class TmmController : BaseController
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
    [HttpPut("UpdateTmm")]
    public async Task<IActionResult> UpdateTmm(UpdateTmmCommand model)
    {
        var command = new UpdateTmmCommand(model.DATE_DEBUT_TMM, model.DATE_FIN_TMM, model.TAUX_TMM, model.ID_TMM);
        var result = await _sender.Send(command);

        if (result.IsSuccess)
        {
            return Ok("Tmm updated successfully");
        }
        else
        {
            return BadRequest(result.ErrorMessage);
        }
    }
    
    [HttpGet("GetAllTmm")]
    public async Task<IActionResult> GetAllTmmm([FromQuery] PaginationParams paginationParams)
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