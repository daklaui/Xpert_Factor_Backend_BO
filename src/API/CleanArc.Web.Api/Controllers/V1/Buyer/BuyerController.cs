using CleanArc.Application.Features.buyer.Commands.AddBuyer;

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
}