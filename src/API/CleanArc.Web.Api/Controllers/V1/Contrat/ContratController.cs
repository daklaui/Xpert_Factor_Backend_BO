using CleanArc.Application.Common;
using CleanArc.Application.Features.Contrat.Commands.AddContratCommand;
using CleanArc.Application.Features.Contrat.Commands.UpdateContratCommand;
using CleanArc.Application.Features.Contrat.Queries;
using CleanArc.Application.Features.Contrat.Queries.GetAllContrats;
using CleanArc.Application.Features.Contrat.Queries.GetContratByIdQuery;
using CleanArc.Application.Models.Common;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Contrat
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/Contrat")]
    //[Authorize]
    public class ContratController : BaseController
    {
        private readonly ISender _sender;

        public ContratController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("CreateNewContrat")]
        public async Task<IActionResult> CreateNewContrat(AddContratCommand model)
        {
            var command = await _sender.Send(model);
            return OperationResult(command);
        }

        [HttpGet("GetAllContrats")]
        public async Task<IActionResult> GetAllContrats([FromQuery] PaginationParams paginationParams)
        {
            var queryResult = await _sender.Send(new GetAllContratsQuery(paginationParams));
            return OperationResult(queryResult);
        }

        [HttpGet("GetContratById/{id}")]
        public async Task<IActionResult> GetContratById(int id)
        {
            var queryResult = await _sender.Send(new GetContratByIdQuery(id));
            return OperationResult(queryResult);
        }

        

        [HttpPut("UpdateContrat")]
        public async Task<IActionResult> UpdateContrat(UpdateContratCommand command)
        {
            var result = await _sender.Send(command);
            return OperationResult(result);
        }
        
        [HttpGet("GetContractsForCurrentYear")]
        public async Task<IActionResult> GetContractsForCurrentYear()
        {
            var queryResult = await _sender.Send(new GetContractsForCurrentYearQuery());
            return Ok(queryResult);

        }
    }
}

