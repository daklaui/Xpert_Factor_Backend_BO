using CleanArc.Application.Features.Limite.Commands.AddLimiteCommand;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Limite;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Limite")]
//[Authorize]

public class LimiteController:BaseController
{
    private readonly ISender _sender;

    public LimiteController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("CreateNewLimite")]
    public async Task<IActionResult> CreateNewLimite(AddLimiteCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
}