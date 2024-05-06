using CleanArc.Application.Common;
using CleanArc.Application.Features.GED.Queries;
using CleanArc.Application.Features.GED.Queries.GetAllGEDValidation;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.GED;
[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/GED")]
public class GEDController:BaseController
{
    private readonly ISender _sender;

    public GEDController(ISender sender)
    {
        _sender = sender;
    }
    [HttpGet("GetAllGEDNumerisation")]
    public async Task<IActionResult> GetAllGEDNumerisation([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllGEDNumerisationQuery(paginationParams));

        return base.OperationResult(query);
    }
    [HttpGet("GetAllGEDValidation")]
    public async Task<IActionResult> GetAllGEDValidation([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllGEDValidationQuery(paginationParams));

        return base.OperationResult(query);
    }
}