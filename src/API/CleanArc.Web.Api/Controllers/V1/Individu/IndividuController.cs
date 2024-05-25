using CleanArc.Application.Common;
using CleanArc.Application.Features.Individu.Commands.AddIndividuCommand;
using CleanArc.Application.Features.Individu.Commands.UpdateIndividuCommand;
using CleanArc.Application.Features.Individu.Queries.GetAllIndividus;
using CleanArc.Application.Features.Individu.Queries.GetByIdQuery;
using CleanArc.Domain.DTO;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CleanArc.Web.Api.Controllers.V1.Individu
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/Individu")]
    //[Authorize]
    public class IndividuController : BaseController
    {
        private readonly ISender _sender;
        private readonly ILogger<IndividuController> _logger;

        public IndividuController(ISender sender, ILogger<IndividuController> logger)
        {
            _sender = sender;
            _logger = logger;
        }

        [HttpPost("CreateNewIndividu")]
        public async Task<IActionResult> CreateNewIndividu([FromBody] IndividualDTO model)
        {
            if (model == null)
            {
                return BadRequest("Invalid model");
            }

            try
            {
                var command = new AddIndividuCommand(model);
                var result = await _sender.Send(command);
                return base.OperationResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during Individual registration.");
                return BadRequest("An error occurred while processing your request.");
            }
        }

        [HttpGet("GetIndividuById/{id}")]
        public async Task<IActionResult> GetIndividuById(int id)
        {
            try
            {
                var query = new GetByIdQuery(id);
                var result = await _sender.Send(query);
                return base.OperationResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error fetching individual with ID: {id}");
                return BadRequest("An error occurred while processing your request.");
            }
        }
        
        [HttpPut("UpdateIndividu/{id}")]
        public async Task<IActionResult> UpdateIndividu(int id, [FromBody] UpdateIndividuCommand model)
        {
            if (model == null)
            {
                return BadRequest("Invalid model");
            }

            try
            {
                var command = await _sender.Send(model);
                return base.OperationResult(command);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating individual.");
                return BadRequest("An error occurred while processing your request.");
            }
        }

        [HttpGet("GetAllIndividus")]
        public async Task<IActionResult> GetAllIndividus([FromQuery] PaginationParams paginationParams)
        {
            try
            {
                var query = new GetAllIndividusQuery(paginationParams);
                var result = await _sender.Send(query);
                return base.OperationResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all individuals.");
                return BadRequest("An error occurred while processing your request.");
            }
        }
    }
}
