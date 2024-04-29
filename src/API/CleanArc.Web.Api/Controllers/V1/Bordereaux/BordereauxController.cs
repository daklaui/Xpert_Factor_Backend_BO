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
        // Parse the id string to extract deletion criteria (assuming specific format)
        var criteria = ParseDeletionCriteria(id);

        // Create PksBordereauxDto with extracted criteria
        var bordereauxDto = new PksBordereauxDto
        {
            NUM_BORD = criteria.NumBord,
            REF_CTR_BORD = criteria.RefCtrBord,
            ANNEE_BORD = criteria.AnneeBord
        };

        // Create GetByIdQuery with the PksBordereauxDto (assuming query now accepts DTO)
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
    /*[HttpPatch("ValidateBordereau/{id}")]
    public async Task<IActionResult> ValidateBordereau(string id)
    {
        // Parse the id string to extract the primary key criteria
        var criteria = ParseDeletionCriteria(id);

        // Create PksBordereauxDto with the extracted criteria
        var pksBordereauxDto = new PksBordereauxDto
        {
            NUM_BORD = criteria.NumBord,
            REF_CTR_BORD = criteria.RefCtrBord,
            ANNEE_BORD = criteria.AnneeBord
        };

        // Create a ValidateBordereauCommand with the PksBordereauxDto
        var command = new ValidateBordereauCommand(pksBordereauxDto);

        // Send the command using the sender and await the result
        var operationResult = await _sender.Send(command);

        // Return the operationResult using the base controller's OperationResult method
        // Return directly since operationResult is already an OperationResult<bool> type
        return base.OperationResult<bool>(operationResult);

    }*/






    private (string NumBord, int RefCtrBord, string AnneeBord) ParseDeletionCriteria(PksDetBordDto id)
    {
        
        return (id.NUM_BORD, id.REF_CTR_DET_BORD,  id.ANNEE_BORD);
    }

}