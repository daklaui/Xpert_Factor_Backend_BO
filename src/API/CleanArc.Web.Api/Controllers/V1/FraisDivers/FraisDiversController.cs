using CleanArc.Application.Common;
using CleanArc.Application.Features.FraisDivers.Commands.AddFraisDiversCommand;
using CleanArc.Application.Features.FraisDivers.Commands.UpdateFraisDiversCommand;
using CleanArc.Application.Features.FraisDivers.Queries.GetAllFraisDivers;
using CleanArc.Application.Features.FraisDivers.Queries.GetByIdQuery;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.FraisDivers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/FraisDivers")]
    //[Authorize]
    public class FraisDiversController : BaseController
    {
        private readonly ISender _sender;

        public FraisDiversController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("CreateNewFraisDivers")]
        public async Task<IActionResult> CreateNewFraisDivers(AddFraisDiversCommand model)
        {
            var command = await _sender.Send(model);
            return base.OperationResult(command);
        }

        [HttpGet("GetAllFraisDivers")]
        public async Task<IActionResult> GetAllFraisDivers([FromQuery] PaginationParams paginationParams)
        {
            var query = await _sender.Send(new GetAllFraisDiversQuery(paginationParams));
            return base.OperationResult(query);
        }

        [HttpGet("GetFraisDiversById/{id}/{id2}")]
        public async Task<IActionResult> GetFraisDiversById(int id , string id2)
        {
            var query = await _sender.Send(new GetByIdFraisDiversQuery(id, id2));
            return base.OperationResult(query);
        }

        [HttpPut("UpdateFraisDivers")]
        public async Task<IActionResult> UpdateFraisDivers(UpdateFraisDiversCommand command)
        {
            var result = await _sender.Send(command);
            return base.OperationResult(result);
        }
    }
}
