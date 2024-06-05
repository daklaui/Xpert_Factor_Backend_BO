using CleanArc.Application.Common;
using CleanArc.Application.Features.Individu.Commands.AddIndividuCommand;
using CleanArc.Application.Features.Individu.Commands.UpdateIndividuCommand;
using CleanArc.Application.Features.Individu.Queries.GetAcheteurPourContrat;
using CleanArc.Application.Features.Individu.Queries.GetAllAdherents;
using CleanArc.Application.Features.Individu.Queries.GetAllDetailsAdherents;
using CleanArc.Application.Features.Individu.Queries.GetAllIndividus;
using CleanArc.Application.Features.Individu.Queries.GetAllNomIndiv;
using CleanArc.Application.Features.Individu.Queries.GetByIdQuery;
using CleanArc.Application.Features.Individu.Queries.GetIndividusSansContrat;
using CleanArc.Application.Features.Individu.Queries.GetRefCtrCirByAdherentName;
using CleanArc.Application.Models.Common;
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
        public async Task<IActionResult> CreateNewIndividu(AddIndividuCommand model)
        {
            var result = await _sender.Send(model);
            return OperationResult(result);
        }

        [HttpGet("GetIndividuById/{id}")]
        public async Task<IActionResult> GetIndividuById(int id)
        {
            try
            {
                var query = new GetByIdQuery(id);
                var result = await _sender.Send(query);
                return OperationResult(result);
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
        [HttpGet("GetAllAdherents")]
        public async Task<IActionResult> GetAllAdherents()
        {
            var query = new GetAllAdherentsQuery();
            var result = await _sender.Send(query);
            Console.WriteLine($"OperationResult Success: {result.IsSuccess}");
            return base.OperationResult(result);
        }
        
        [HttpGet("GetRefCtrCirByRefInd/{refInd}")]
        public async Task<IActionResult> GetRefCtrCirByRefInd(int refInd)
        {
            var query = new GetRefCtrCirByRefIndQuery(refInd);
            var result = await _sender.Send(query);
            return base.OperationResult(result);
        }
        
        
        [HttpGet("GetAllNomIndividus")]
        public async Task<IActionResult> GetAllNomIndividus()
        {
            try
            {
                var query = new GetAllNomIndivQuery();
                var result = await _sender.Send(query);
                return base.OperationResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all name individuals.");
                return BadRequest("An error occurred while processing your request.");
            }
        }
        
        [HttpGet("GetAllDetailsAdherents")]
        public async Task<IActionResult> GetAllDetailsAdherents(int refCTR)
        {
            var query = new GetAllDetailsAdherentsQuery(refCTR);
            var result = await _sender.Send(query);
            Console.WriteLine($"OperationResult Success: {result.IsSuccess}");
            return base.OperationResult(result);
        }
        
        [HttpGet("GetIndividusSansContrat")]
        public async Task<IActionResult> GetIndividusSansContrat(int refctr)
        {
            var query = new GetIndividusSansContratQuery(refctr);
            var result = await _sender.Send(query);
            Console.WriteLine($"OperationResult Success: {result.IsSuccess}");
            return base.OperationResult(result);
        }
        
       
        [HttpGet("GetAcheteursPourContrat")]
        public async Task<IActionResult> GetAcheteursPourContrat(int refctr)
        {
            var query = new GetAcheteurPourContratQuery(refctr);
            var result = await _sender.Send(query);
            Console.WriteLine($"OperationResult Success: {result.IsSuccess}");
            return base.OperationResult(result);
        }
    }
    }
    