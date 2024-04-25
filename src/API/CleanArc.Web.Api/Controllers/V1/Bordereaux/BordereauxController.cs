using CleanArc.Application.Common;
using CleanArc.Application.Features.Bordereaux.Commands.AddBordereauxCommand;
using CleanArc.Application.Features.Bordereaux.Commands.DeleteBordereauxCommand;
using CleanArc.Application.Features.Bordereaux.Queries.GetAllBordereaux;
using CleanArc.Application.Features.Bordereaux.Queries.GetById;
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
    
    [HttpGet("GetBordereauxById/{id}")]
    public async Task<IActionResult> GetBordereauxById(string id)
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
    
    [HttpDelete("DeleteBordereaux/{id}")]
    public async Task<IActionResult> DeleteBordereaux(string id)
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


    private (string NumBord, int RefCtrBord, string AnneeBord) ParseDeletionCriteria(string id)
    {
        
        var parts = id.Split('-');
        return (parts[0], int.Parse(parts[1]), parts[2]);
    }

}