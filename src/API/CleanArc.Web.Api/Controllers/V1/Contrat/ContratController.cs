using CleanArc.Application.Common;
using CleanArc.Application.Features.Contrat.Commands.AddContratCommand;
using CleanArc.Application.Features.Contrat.Commands.UpdateContratCommand;
using CleanArc.Application.Features.Contrat.Queries;
using CleanArc.Application.Features.Contrat.Queries.GetAllContrats;
using CleanArc.Application.Features.Contrat.Queries.GetContratByIdQuery;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;
using CleanArc.Application.Features.Contrat.Queries.GetAllInvoicesByContratAndBuyer;
using Microsoft.AspNetCore.Authorization; // Ajout de l'importation nécessaire
namespace CleanArc.Web.Api.Controllers.V1.Contrat
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/Contrat")]
    [Authorize]
    public class ContratController : BaseController
    {
        private readonly ISender _sender;
        public ContratController(ISender sender) // Ajout de IContratRepository dans le constructeur
        {
            _sender = sender;
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
        
        [HttpGet("GetAllInvoicesByContratAndBuyer")]
        public async Task<IActionResult> GetAllInvoicesByContratAndBuyer(int refadh, int refach)
        {
            var query = new GetAllInvoicesByContratAndBuyerQuery(refadh,  refach);
            var result = await _sender.Send(query);
            Console.WriteLine($"OperationResult Success: {result.IsSuccess}");
            return base.OperationResult(result);
        }
    }
}
