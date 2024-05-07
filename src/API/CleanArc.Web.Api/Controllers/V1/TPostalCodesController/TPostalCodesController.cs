
using CleanArc.Application.Common;
using CleanArc.Application.Features.TPostalCodes.Commands;
using CleanArc.Application.Features.TPostalCodes.Queries.GetAllTPostalCodes;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CleanArc.Application.Features.TPostalCodes.Queries.GetTPostalCodesById;

namespace CleanArc.Web.Api.Controllers.V1.TPostalCodesController
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/TPostalCodes")]
    public class TPostalCodesController : BaseController
    {
        private readonly ISender _sender;

        public TPostalCodesController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("CreateNewTPostalCode")]
        public async Task<IActionResult> CreateNewTPostalCode(AddTPostalCodesCommand model)
        {
            if (model == null)
            {
                return BadRequest("Invalid model");
            }

            var commandResult = await _sender.Send(model);

            if (commandResult == null || !commandResult.IsSuccess)
            {
                return BadRequest("Failed to create new TPostalCode");
            }

            return Ok("TPostalCode created successfully");
        }

        [HttpGet("GetAllTPostalCodes")]
        public async Task<IActionResult> GetAllTPostalCodes([FromQuery] PaginationParams paginationParams)
        {
            if (paginationParams == null)
            {
                return BadRequest("PaginationParams cannot be null.");
            }

            var query = await _sender.Send(new GetAllTPostalCodesQuery(paginationParams));

            if (query == null)
            {
                return NotFound();
            }

            return base.OperationResult(query);
        }

        [HttpGet("GetTPostalCodeById/{id}")]
        public async Task<IActionResult> GetTPostalCodeById(int id)
        {
            var query = await _sender.Send(new GetTPostalCodesByIdQuery(id));
            return base.OperationResult(query);
        }

        [HttpPut("UpdateTPostalCode/{id}")]
        public async Task<IActionResult> UpdateTPostalCode(int id, UpdateTPostalCodesCommand model)
        {
            if (model == null)
            {
                return BadRequest("Invalid model");
            }

            model.Id = id; 

            var commandResult = await _sender.Send(model);

            if (commandResult == null || !commandResult.IsSuccess)
            {
                return BadRequest("Failed to update TPostalCode");
            }

            return Ok("TPostalCode updated successfully");
        }
    }
}
