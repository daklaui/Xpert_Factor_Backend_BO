using CleanArc.Application.Common;
using CleanArc.Application.Features.PostalCode.Commands.AddPostalCodeCommand;
using CleanArc.Application.Features.PostalCode.Commands.UpdatePostalCodeCommand;
using CleanArc.Application.Features.PostalCode.Queries.GetAllPostalCodeQuery;
using CleanArc.Application.Features.PostalCode.Queries.GetByIdPostalCodeQuery;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.PostalCode;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/PostalCode")]
//[Authorize]
public class PostalCodeController:BaseController
{
    private readonly ISender _sender;

    public PostalCodeController(ISender sender)
    {
        _sender = sender;
    }
    [HttpPost("CreateNewPostalCode")]
    public async Task<IActionResult> CreatePostalCode(AddPostalCodeCommand model)
    {
        
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }   
    [HttpPut("UpdatePostalCode/{id}")]
    public async Task<IActionResult> UpdatePostalCode(int id, UpdatePostalCodeCommand model)
    {
        if (model == null)
        {
            return BadRequest("Invalid model");
        }
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    [HttpGet("GetAllPostalCodes")]
    public async Task<IActionResult> GetAllJobs([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllPostalCodeQuery(paginationParams));

        return base.OperationResult(query);
    }

    [HttpGet("GetPostalCodeById/{id}")]
    public async Task<IActionResult> GetJobById(int id)
    {
        var query = await _sender.Send(new GetByIdPostalCodeQuery(id));

        return base.OperationResult(query);
    }
}