using CleanArc.Application.Common;
using CleanArc.Application.Features.Impaye.Commands.AddImpayeCommand;
using CleanArc.Application.Features.Impaye.Queries;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Impaye;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Imapye")]
//[Authorize]
public class ImpayeController:BaseController
{
    private readonly ISender _sender;

    public ImpayeController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("CreateNewImpaye")]
    public async Task<IActionResult> CreateNewImpaye(AddImpayeCommand model)
    {
        
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    
    [HttpGet("GetListOfImpaye")]
    public async Task<IActionResult> GetListOfImpaye([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetListOfImpayeQuery(paginationParams));

        return base.OperationResult(query);
    }
    
 
}