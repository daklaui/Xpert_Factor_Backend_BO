using CleanArc.Application.Common;
using CleanArc.Application.Features.Bordereaux.Commands.AddBordereauxCommand;
using CleanArc.Application.Features.Bordereaux.Commands.DeleteBordereauxCommand;
using CleanArc.Application.Features.Bordereaux.Commands.UpdateBordereauxCommand;
using CleanArc.Application.Features.Bordereaux.Commands.ValidateBordereauCommand;
using CleanArc.Application.Features.Bordereaux.Queries.GetAllBordereaux;
using CleanArc.Application.Features.Bordereaux.Queries.GetById;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Bordereaux;
[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Bordereaux")]
public class BordereauxController : BaseController
{
    private readonly ISender _sender;

    public BordereauxController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("CreateNewBordereaux")]
    public async Task<IActionResult> CreateNewBordereaux(AddBordereauxCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    
    [HttpGet("GetAllBordereaux")]
    public async Task<IActionResult> GetAllBordereaux([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllBordereauxQuery(paginationParams));

        return base.OperationResult(query);
    }
    
    [HttpGet("GetBordereauxById")]
    public async Task<IActionResult> GetBordereauxById([FromQuery] PksDetBordDto id)
    {
        
        var criteria = ParseDeletionCriteria(id);

       
        var bordereauxDto = new PksBordereauxDto
        {
            NUM_BORD = criteria.NumBord,
            REF_CTR_BORD = criteria.RefCtrBord,
            ANNEE_BORD = criteria.AnneeBord
        };

       
        var query = new GetByIdQuery(bordereauxDto);

        var result = await _sender.Send(query);

        return base.OperationResult(result);
    }
    
    [HttpDelete("DeleteBordereaux")]
    public async Task<IActionResult> DeleteBordereaux([FromQuery] PksDetBordDto id)
    {
        
        var criteria = ParseDeletionCriteria(id);

        
        var deleteDto = new PksBordereauxDto
        {
            NUM_BORD = criteria.NumBord,
            REF_CTR_BORD = criteria.RefCtrBord,
            ANNEE_BORD = criteria.AnneeBord
        };

        
        var command = new DeleteBordereauxCommand { BordereauToDelete = deleteDto };

        var result = await _sender.Send(command);

        return base.OperationResult<bool>(result);
    }
    [HttpPut("UpdateBordereaux")]
    public async Task<IActionResult> UpdateBordereaux([FromBody] UpdateBordereauxCommand model)
    {
        var command = await _sender.Send(model);
        return base.OperationResult(command);
    }
    
    [HttpPut("ValidateBordereau")]
    public async Task<IActionResult> ValidateBordereau([FromBody] PksBordereauxDto pksBordereauxDto)
    {
        var command = new ValidateBordereauCommand(pksBordereauxDto);
     
        var result = await _sender.Send(command);
    
        return base.OperationResult<bool>(result);
        
        
    }

    
    private (string NumBord, int RefCtrBord, string AnneeBord) ParseDeletionCriteria(PksDetBordDto id)
    {
        
        return (id.NUM_BORD, id.REF_CTR_DET_BORD,  id.ANNEE_BORD);
    }

}