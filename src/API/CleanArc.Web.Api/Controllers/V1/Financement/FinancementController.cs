using CleanArc.Application.Features.Financement.Commands.AddFinancementCommand;
using CleanArc.Application.Features.Financement.Queries;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Financement;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Financement")]
public class FinancementController:BaseController
{
    private readonly ISender _sender;
    
    public FinancementController(ISender sender)
    {
        _sender = sender;
    }
    [HttpGet("GetFinancementById/{id}")]
    public async Task<IActionResult> GetFinancementById(int id)
    {
        var query = await _sender.Send(new GetFinancementByIdQuery(id));

        return base.OperationResult(query);
    }
    
    
    [HttpPost("CreateNewFinancement")]
    public async Task<IActionResult> CreateNewFinancement(AddFinancementCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    
}