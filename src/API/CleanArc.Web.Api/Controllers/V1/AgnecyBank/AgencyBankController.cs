using CleanArc.Application.Common;
using CleanArc.Application.Features.AgencyBank.Commands.AddAgencyBankCommand;
using CleanArc.Application.Features.AgencyBank.Commands.UpdateAgencyBankCommand;
using CleanArc.Application.Features.AgencyBank.Queries.GetAgnecyBankByIdQuerie;
using CleanArc.Application.Features.AgencyBank.Queries.RechercheBanqueQuerie;
using CleanArc.Application.Features.AgencyBank.Queries.SearchAgencyQuerie;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.AgnecyBank;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/AgencyBank")]
public class AgencyBankController : BaseController
{
    private readonly ISender _sender;

    public AgencyBankController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("CreateNewBankAgency")]
    public async Task<IActionResult> CreateNewAgencyBank(AddAgencyBankCommand model)
    {
    
        var command = await _sender.Send(model);
        return base.OperationResult(command);
    }
    
    [HttpGet("GetAllAgencyBank")]
    public async Task<IActionResult> GetAllAgencyBank([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllAgencyBankQuery(paginationParams));
        return base.OperationResult(query);
    } 
    
    [HttpGet("GetAgencyBankById")]
    public async Task<IActionResult> GetIndividuById(string code )
    {
        var query = await _sender.Send(new GetAgencyBankByIdQuery(code));

        return base.OperationResult(query);
    }
    
    [HttpGet("SearchBank")]
    public async Task<IActionResult> SearchBank(string codeBank )
    {
        var query = await _sender.Send(new SearchBankQuery(codeBank));

        return base.OperationResult(query);
    }
     
    [HttpGet("SearchAgency")]
    public async Task<IActionResult> SearchAgency(string codeAgency )
    {
        var query = await _sender.Send(new SearchAgencyQuery(codeAgency));

        return base.OperationResult(query);
    }
    
    

    [HttpPut("UpdateBankAgency")]
    public async Task<IActionResult> UpdateBankAgency(UpdateAgencyBankCommand model)
    {
        var command = new UpdateAgencyBankCommand(model.Code_Bq_Ag, model.Code_Bq, model.Banque, model.Code_Ag, model.Agence);
        var result = await _sender.Send(command);

        if (result.IsSuccess)
        {
            return Ok("Bank agency updated successfully");
        }
        else
        {
            return BadRequest(result.ErrorMessage);
        }
    }
    
    
    
    
    
}


