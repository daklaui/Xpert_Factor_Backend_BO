using CleanArc.Application.Common;
using CleanArc.Application.Features.TjDocumentDetBord.Commands.AddTjDocumentCommand;
using CleanArc.Application.Features.TjDocumentDetBord.Commands.DeleteTjDocumentCommand;
using CleanArc.Application.Features.TjDocumentDetBord.Queries.GetAllTjDocument;
using CleanArc.Application.Features.TjDocumentDetBord.Queries.GetById;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.TjDocumentDetBord;
[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/TjDocument")]
public class TjDocumentController : BaseController
{
    private readonly ISender _sender;

    public TjDocumentController(ISender sender)
    {
        _sender = sender;
    }
    [HttpPost("CreateNewTjDocument")]
    public async Task<IActionResult> CreateNewBordereaux(AddTjDocumentCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    
    [HttpGet("GetAllTjDocument")]
    public async Task<IActionResult> GetAllTjDocument([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllTjDocumentQuery(paginationParams));

        return base.OperationResult(query);
    }
    
    [HttpGet("GetTjDocumentById/{id}")]
    public async Task<IActionResult> GetTjDocumentById(int id)
    {
        var query = await _sender.Send(new GetByIdQuery(id));

        return base.OperationResult(query);
    }
    
    [HttpDelete("DeleteTjDocument/{id}")]
    public async Task<IActionResult> DeleteTjDocument(int id)
    {
        var command = await _sender.Send(new DeleteTjDocumentCommand() { TjDocumentId = id });
        return base.OperationResult<bool>(command);

    }
}