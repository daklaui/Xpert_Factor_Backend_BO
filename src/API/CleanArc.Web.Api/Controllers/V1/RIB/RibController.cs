using CleanArc.Application.Common;
using CleanArc.Application.Features.RIB.Commands.AddRibCommand;
using CleanArc.Application.Features.RIB.Commands.EditRibIndividuCommand;
using CleanArc.Application.Features.RIB.Queries.GetAllRibsByIndividuQueries;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.RIB;
[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Rib")]
//[Authorize]
public class RibController:BaseController
{
    private readonly ISender  _sender;

    public RibController(ISender sender)
    {
        _sender = sender;
    }
    
    
    [HttpPost("CreateNewRib")]
    public async Task<IActionResult> CreateNewRib(AddRibCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    
    [HttpGet("GetAllRibsByIndividu")]
    public async Task<IActionResult> GetAllRibsByIndividu(int refIndRib ,[FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllRibsByIndividuQuery(refIndRib,paginationParams));

        return base.OperationResult(query);
    }
    [HttpPost("EditRibIndividu")]
    public async Task<IActionResult> EditRibIndividu(EditRibIndividuCommand model)
    {
        var command = new EditRibIndividuCommand
        {
            RIB_RIB1 = model.RIB_RIB1,
            RIB_RIB2 = model.RIB_RIB2,
            RIB_RIB3 = model.RIB_RIB3,
            REF_IND_RIB = model.REF_IND_RIB,
            ACTIF_RIB = model.ACTIF_RIB,
            OLD_RIB_RIB = model.OLD_RIB_RIB
        };

        var result = await _sender.Send(command);

        return base.OperationResult(result);
    }
    
    
}