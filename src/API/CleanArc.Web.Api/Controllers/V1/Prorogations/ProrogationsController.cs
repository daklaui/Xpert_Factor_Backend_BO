using CleanArc.Application.Features.Prorogations.Commands;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Prorogations;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Prorogations")]
public class ProrogationsController:BaseController
{
    private readonly ISender _sender;
    public ProrogationsController(ISender sender)
    {
        _sender = sender;
    }
    [HttpPost("CreateNewProrogation")]
    public async Task<IActionResult> CreateNewProrogation(AddProrogationsCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
}