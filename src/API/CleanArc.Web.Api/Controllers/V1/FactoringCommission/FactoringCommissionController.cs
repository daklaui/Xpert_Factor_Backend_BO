using CleanArc.Application.Common;
using CleanArc.Application.Features.FactoringCommission.Queries.GetAllFactoringCommissions;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;
using CleanArc.Application.Features.FactoringCommission.Commands.AddFactoringCommissionCommand;
using CleanArc.Application.Features.FactoringCommission.Commands.UpdateFactoringCommissionCommand;
using CleanArc.Application.Features.FactoringCommission.Queries.GetByIdQuery;

namespace CleanArc.Web.Api.Controllers.V1.FactoringCommission
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/FactoringCommission")]
    //[Authorize]
    public class FactoringCommissionController : BaseController
    {
        private readonly ISender _sender;

        public FactoringCommissionController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("CreateNewFactoringCommission")]
        public async Task<IActionResult> CreateNewFactoringCommission(AddFactoringCommissionCommand command)
        {
            var result = await _sender.Send(command);
            return base.OperationResult(result);
        }

        [HttpGet("GetAllFactoringCommissions")]
        public async Task<IActionResult> GetAllFactoringCommissions([FromQuery] PaginationParams paginationParams)
        {
            var query = await _sender.Send(new GetAllFactoringCommissionsQuery(paginationParams));
            return base.OperationResult(query);
        }

        [HttpGet("GetFactoringCommissionById/{id}")]
        public async Task<IActionResult> GetFactoringCommissionById(int id)
        {
            var query = await _sender.Send(new GetByIdQuery(id));
            return base.OperationResult(query);
        }

        [HttpPut("UpdateFactoringCommission")]
        public async Task<IActionResult> UpdateFactoringCommission(UpdateFactoringCommissionCommand command)
        {
            var result = await _sender.Send(command);
            return base.OperationResult(result);
        }
    }
}
