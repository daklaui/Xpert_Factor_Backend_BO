
using CleanArc.Application.Features.Debit.Commands.AddDebitCommand;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Debit;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Debit")]
public class DebitController:BaseController
{
    private readonly ISender _sender;

    public DebitController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("CreateNewDebit")]
    public async Task<IActionResult> CreateNewDebit(AddDebitCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }

}