using CleanArc.Application.Common;
using CleanArc.Application.Features.ValuesList.Queries.GetContactsList;
using CleanArc.Application.Features.ValuesList.Queries.GetFromJuridiqueList;
using CleanArc.Application.Features.ValuesList.Queries.GetJobsList;
using CleanArc.Application.Features.ValuesList.Queries.GetLangList;
using CleanArc.Application.Features.ValuesList.Queries.GetPostsList;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.List_Of_Values;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/List_Of_Values")]
//[Authorize]
public class List_Of_ValuesController : BaseController
{
    private readonly ISender _sender;

    public List_Of_ValuesController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpGet("GetContactsList")]
    public async Task<IActionResult> GetContactsList([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetContactsListQuery(paginationParams));

        return base.OperationResult(query);
    }
    
    [HttpGet("GetFromJuridiqueList")]
    public async Task<IActionResult> GetFromJuridiqueList([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetFromJuridiqueListQuery(paginationParams));

        return base.OperationResult(query);
    }
    
    [HttpGet("GetJobsList")]
    public async Task<IActionResult> GetJobsList([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetJobsListQuery(paginationParams));

        return base.OperationResult(query);
    }
    
    [HttpGet("GetLangList")]
    public async Task<IActionResult> GetLangList([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetLangListQuery(paginationParams));

        return base.OperationResult(query);
    }
    
    [HttpGet("GetPostsList")]
    public async Task<IActionResult> GetPostsList([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetPostsListQuery(paginationParams));

        return base.OperationResult(query);
    }
    
}