using CleanArc.Application.Common;
using CleanArc.Application.Features.TjDocumentDetBord.Commands.AddTjDocumentCommand;
using CleanArc.Application.Features.TJob.Commands.AddTJob;
using CleanArc.Application.Features.TJob.Commands.UpdateTJobCommand;
using CleanArc.Application.Features.TJob.Queries.GetAllTJobs;
using CleanArc.Application.Features.TJob.Queries.GetTJobsByIdQuery;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.TJobs;
[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/TJob")]
//[Authorize]
public class TJobsController:BaseController
{    
    private readonly ISender _sender;

    public TJobsController(ISender sender)
    {
        _sender = sender;
    }
    [HttpPost("CreateNewTjob")]
    public async Task<IActionResult> CreateNewJob(AddTJobCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    
    [HttpGet("GetAllJobs")]
    public async Task<IActionResult> GetAllJobs()
    {
        var query = await _sender.Send(new GetAllTJobsQuery());

        return base.OperationResult(query);
    }
    
    [HttpPut("UpdateJob/{id}")]
    public async Task<IActionResult> UpdateJob(int id, UpdateTJobsCommand model)
    {
        if (model == null)
        {
            return BadRequest("Invalid model");
        }
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    [HttpGet("GetJobById/{id}")]
    public async Task<IActionResult> GetJobById(string id)
    {
        var query = await _sender.Send(new GetTJobsByIdQuery(id));

        return base.OperationResult(query);
    }


}