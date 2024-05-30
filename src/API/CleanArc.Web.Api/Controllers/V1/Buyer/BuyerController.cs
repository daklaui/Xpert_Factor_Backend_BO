using CleanArc.Application.Features.buyer.Commands.AddBuyer;
using CleanArc.Application.Features.buyer.Commands.AddBuyerLimit;
using CleanArc.Application.Features.buyer.Commands.Queries;

namespace CleanArc.Web.Api.Controllers.V1.Buyer;

using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Buyer")]
//[Authorize]

public class BuyerController:BaseController
{
    private readonly ISender _sender;

    public BuyerController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("AddBuyer")]
    public async Task<IActionResult> AddBuyer(AddBuyerCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    [HttpGet("GetAllAcheteursByContrat")]
    public async Task<IActionResult> GetAllAcheteursByContrat(int id)
    {
        var query = new GetAcheteursByContratQuery(id);
        var result = await _sender.Send(query);
        return base.OperationResult(result);
    }
    
    [HttpPost("AddBuyerLimit")]
    public async Task<IActionResult> AddBuyerLimit( AddBuyerLimitCommmand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
} 