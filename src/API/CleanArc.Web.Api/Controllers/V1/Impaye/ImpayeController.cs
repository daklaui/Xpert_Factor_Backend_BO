using CleanArc.Application.Common;
using CleanArc.Application.Features.Impaye.Commands.AddImpayeCommand;
using CleanArc.Application.Features.Impaye.Queries;
using CleanArc.Application.Features.Impaye.Queries.GetListehistorical;
using CleanArc.Application.Features.Impaye.Queries.GetListeResolutionDesImpayes;
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
 [HttpGet("GetListOfImpaye")]
    public async Task<IActionResult> GetListOfImpaye([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetListOfImpayeQuery(paginationParams));
        return base.OperationResult(query);
    }
    [HttpPost("CreateNewImpaye")]
    public async Task<IActionResult> CreateNewImpaye(AddImpayeCommand model)
    {
        
        var command = await _sender.Send(model);
        return base.OperationResult(command);
    }
    
   
    [HttpGet("GetListeHistorical")]
    public async Task<IActionResult> GetListeHistorical([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetListeHistoricalQuery(paginationParams));

        return base.OperationResult(query);
    }
    [HttpGet("GetListeResolutionDesImpayes")]
    public async Task<IActionResult> GetListeResolutionDesImpayesQuery([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetListeResolutionDesImpayesQuery(paginationParams));
        return base.OperationResult(query);
    }


 
}