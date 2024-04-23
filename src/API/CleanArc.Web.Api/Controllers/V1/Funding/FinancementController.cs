using CleanArc.Application.Features.Financement.Queries;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Funding;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Funding")]
public class FundingController:BaseController
{
    private readonly ISender _sender;
    
    public FundingController(ISender sender)
    {
        _sender = sender;
    }
    [HttpGet("GetFundingById/{id}")]
    public async Task<IActionResult> GetFundingById(int id)
    {
        var query = await _sender.Send(new GetFundingByIdQuery(id));

        return base.OperationResult(query);
    } 
    
    
    [HttpGet("GetFundingByRefCTr/{id}")]
    public async Task<IActionResult> GetFundingByRefCTr(int id)
    {
        var query = await _sender.Send(new GetFundingByRefCtrQuery(id));

        return base.OperationResult(query);
    }
    
 
    
}