using CleanArc.Application.Features.Individu.Commands.AddIndividuCommand;
using CleanArc.Application.Features.Order.Commands;
using CleanArc.Application.Features.Order.Queries.GetUserOrders;
using CleanArc.WebFramework.BaseController;
using CleanArc.WebFramework.WebExtensions;
using Mediator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Individu;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Individu")]
//[Authorize]
public class IndividuController : BaseController
{
    private readonly ISender _sender;

    public IndividuController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("CreateNewIndividu")]
    public async Task<IActionResult> CreateNewIndividu(AddIndividuCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }

    /*[HttpGet("GetUserOrders")]
    public async Task<IActionResult> GetUserOrders()
    {
        var query = await _sender.Send(new GetUserOrdersQueryModel(UserId));

        return base.OperationResult(query);
    }*/
}