using CleanArc.Application.Features.TMM.Commands.AddTmmCommand;

namespace CleanArc.Web.Api.Controllers.V1.TMM;
using CleanArc.Application.Common;

using CleanArc.Application.Features.Order.Commands;
using CleanArc.Application.Features.Order.Queries.GetUserOrders;
using CleanArc.WebFramework.BaseController;
using CleanArc.WebFramework.WebExtensions;
using Mediator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Tmm")]
//[Authorize]
public class TmmController :BaseController
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
}