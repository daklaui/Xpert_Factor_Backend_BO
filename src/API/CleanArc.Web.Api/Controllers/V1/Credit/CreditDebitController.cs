using CleanArc.Application.Features.Credit.Commands;
using CleanArc.Application.Features.Debit.Commands.AddDebitCommand;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Credit;


[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/CreditDebit")]
//[Authorize]
public class CreditDebitController:BaseController
{
    private readonly ISender _sender;

    public CreditDebitController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("CreateNewCredit")]
    public async Task<IActionResult> CreateNewCredit(AddCreditCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    [HttpPost("CreateNewDebit")]
    public async Task<IActionResult> CreateNewCredit(AddDebitCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }


}