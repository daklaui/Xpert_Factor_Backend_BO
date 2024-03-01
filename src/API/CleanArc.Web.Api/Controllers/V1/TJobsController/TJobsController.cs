using CleanArc.Application.Common;
using CleanArc.Application.Features.TJobs.Commands;
using CleanArc.Application.Features.TJobs.Queries.GetAllTJobs;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CleanArc.Application.Features.TJobs.Commands.UpdateTJobs;
using CleanArc.Application.Features.TJobs.Queries.GetTJobsById;
using CleanArc.Application.Features.TJobs.TJobs.Commands.AddTJobs;

namespace CleanArc.Web.Api.Controllers.V1.TJobsController
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/TJobs")]
    public class TJobsController : BaseController
    {
        private readonly ISender _sender;

        public TJobsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("CreateNewTJob")]
        public async Task<IActionResult> CreateNewTJob(AddTJobsCommand model)
        {
            if (model == null)
            {
                return BadRequest("Invalid model");
            }

            var commandResult = await _sender.Send(model);

            if (commandResult == null || !commandResult.IsSuccess)
            {
                return BadRequest("Failed to create new TJob");
            }

            return Ok("TJob created successfully");
        }

        [HttpGet("GetAllTJobs")]
        public async Task<IActionResult> GetAllTJobs([FromQuery] PaginationParams paginationParams)
        {
            if (paginationParams == null)
            {
                return BadRequest("PaginationParams cannot be null.");
            }

            var query = await _sender.Send(new GetAllTJobsQuery(paginationParams));

            if (query == null)
            {
                return NotFound();
            }

            return base.OperationResult(query);
        }

        [HttpGet("GetTJobById/{id}")]
        public async Task<IActionResult> GetTJobById(int id)
        {
            var query = await _sender.Send(new GetTJobsByIdQuery(id));
            return base.OperationResult(query);
        }

        [HttpPut("UpdateTJob/{id}")]
        public async Task<IActionResult> UpdateTJob(int id, UpdateTJobsCommand model)
        {
            if (model == null)
            {
                return BadRequest("Invalid model");
            }

            model.Id = id; // Assign the id to the command model

            var commandResult = await _sender.Send(model);

            if (commandResult == null || !commandResult.IsSuccess)
            {
                return BadRequest("Failed to update TJob");
            }

            return Ok("TJob updated successfully");
        }
    }
}
