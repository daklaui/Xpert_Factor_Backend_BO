using CleanArc.Application.Common;
using CleanArc.Application.Features.Contrat.Commands.AddContratCommand;
using CleanArc.Application.Features.Contrat.Commands.UpdateContratCommand;
using CleanArc.Application.Features.Contrat.Queries;
using CleanArc.Application.Features.Contrat.Queries.GetAllContrats;
using CleanArc.Application.Features.Contrat.Queries.GetContratByIdQuery;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CleanArc.Application.Contracts.Persistence; // Ajout de l'importation nécessaire

namespace CleanArc.Web.Api.Controllers.V1.Contrat
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/Contrat")]
    //[Authorize]
    public class ContratController : BaseController
    {
        private readonly ISender _sender;
        private readonly IContratRepository _contratRepository; // Injection de dépendance pour IContratRepository

        public ContratController(ISender sender, IContratRepository contratRepository) // Ajout de IContratRepository dans le constructeur
        {
            _sender = sender;
            _contratRepository = contratRepository; // Assignation de contratRepository
        }

        [HttpPost("CreateNewContrat")]
        public async Task<IActionResult> CreateNewContrat(AddContratCommand model)
        {
            var command = await _sender.Send(model);
            return OperationResult(command);
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
        
        [HttpGet("GetAllContrats")]
        public async Task<IActionResult> GetAllContratcs([FromQuery] PaginationParams paginationParams)
        {
            var queryResult = await _contratRepository.GetAllContratAsync(paginationParams); 
            return Ok(queryResult);
        }
    }
}
