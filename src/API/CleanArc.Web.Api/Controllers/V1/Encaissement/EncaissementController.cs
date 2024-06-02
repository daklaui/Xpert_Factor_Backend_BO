using CleanArc.Application.Common;
using CleanArc.Application.Features.Encaissement.Commands.AddEncaissementCommand;
using CleanArc.Application.Features.Encaissement.Queries.ListeEncAchRefCtr;
using CleanArc.Application.Features.Encaissement.Queries.ListeRecherchEncCtr;
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
    
    [HttpGet("ListeEncAchRefCtr")]
    public async Task<IActionResult> GetListeEncAchRefCtr(int refCtr,int refAch)
    {
        var query = await _sender.Send(new ListeEncAchRefCtrQuery(refCtr,refAch));
        return base.OperationResult(query);
    }
    [HttpGet("ListeEncCtr")]
    public async Task<IActionResult> GetListeEncCtr(int refCtr)
    {
        var query = await _sender.Send(new RecherchEncCtrQuery(refCtr));
        return base.OperationResult(query);
    }
    
    
}