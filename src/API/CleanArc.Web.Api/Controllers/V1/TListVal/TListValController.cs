using CleanArc.Application.Common;
using CleanArc.Application.Features.ListVals.Commands.UpdateTListValCommand;
using CleanArc.Application.Features.TListVal.Commands;
using CleanArc.Application.Features.TListVal.Queries.GetAllTListVals;
using CleanArc.Application.Features.TListVal.Queries.GetByIdQuery;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.TListVal
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/TListVal")]
    public class TListValController : BaseController
    {
        private readonly ISender _sender;

        public TListValController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("CreateNewTListVal")]
        public async Task<IActionResult> CreateNewTListVal(AddTListValCommand model)
        {
            if (model == null)
            {
                return BadRequest("Invalid model");
            }

            var commandResult = await _sender.Send(model);

            if (commandResult == null || !commandResult.IsSuccess)
            {
                return BadRequest("Failed to create new TListVal");
            }

            return Ok("TListVal created successfully");
        }


        [HttpGet("GetAllTListVals")]
        public async Task<IActionResult> GetAllTListVals([FromQuery] PaginationParams paginationParams)
        {
            if (paginationParams == null)
            {
                return BadRequest("PaginationParams cannot be null.");
            }

            var query = await _sender.Send(new GetAllTListValsQuery(paginationParams));

            if (query == null)
            {
                return NotFound();
            }

            return base.OperationResult(query);
        }

        
        [HttpGet("GetTListValById/{id}")]
        public async Task<IActionResult> GetTListValById(int id)
        {
            var query = await _sender.Send(new GetTListValByIdQuery(id));
            return base.OperationResult(query);
            
        }
        
        [HttpPut("UpdateTListVal/{id}")]
        public async Task<IActionResult> UpdateTListVal(int id, UpdateTListValCommand model)
        {
            if (model == null)
            {
                return BadRequest("Invalid model");
            }

            model.Id = id; // Assign the id to the command model

            var commandResult = await _sender.Send(model);

            if (commandResult == null || !commandResult.IsSuccess)
            {
                return BadRequest("Failed to update TListVal");
            }

            return Ok("TListVal updated successfully");
        }



        
    }
}