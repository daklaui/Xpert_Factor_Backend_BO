using CleanArc.Application.Features.Encaissement.Commands.AddEncaissementCommand;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Encaissement;
[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Encaissement")]
public class EncaissementController:BaseController
{
    private readonly ISender _sender;

    public EncaissementController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("CreateNewEncaissement")]
    public async Task<IActionResult> CreateNewEncaissement(AddEncaissementCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    
    
    
    
}