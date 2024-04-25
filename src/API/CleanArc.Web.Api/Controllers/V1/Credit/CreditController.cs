using CleanArc.Application.Features.Credit.Commands.AddCreditCommand;
using CleanArc.WebFramework.BaseController;
using Microsoft.AspNetCore.Mvc;
using Mediator;
namespace CleanArc.Web.Api.Controllers.V1.Credit;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Credit")]
public class CreditController:BaseController
{
    private readonly ISender _sender;

    public CreditController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("CreateNewCredit")]
    public async Task<IActionResult> CreateNewCredit(AddCreditCommand model)
    {
    
        var command = await _sender.Send(model);


        return base.OperationResult(command);
    }

}