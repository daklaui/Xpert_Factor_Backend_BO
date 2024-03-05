using CleanArc.Application.Features.BankAgency.Commands.AddBankAgencyCommand;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.BankAgency;

[Route("api/v{version:apiVersion}/Bank")]
[ApiVersion("1")]
[ApiController]
public class BankAgencyController : BaseController
{
    private readonly ISender _sender;

    public BankAgencyController(ISender sender)
    {
        _sender = sender;
    }
  

    [HttpPost("CreateNewBankAgency")]
    public async Task<IActionResult> CreateNewBankAgency(AddAgBqCommand model)
    {
        var command = await _sender.Send(model);
        return base.OperationResult(command);
    }
}