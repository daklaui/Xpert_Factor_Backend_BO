using CleanArc.Application.Common;
using CleanArc.Application.Features.ListValue.Commands.AddListValueCommand;
using CleanArc.Application.Features.ListValue.Commands.UpdateListValueCommand;
using CleanArc.Application.Features.ListValue.Queries.GetAllListValues;
using CleanArc.Application.Features.ListValue.Queries.GetById;

using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.ListValue
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/ListValue")]
    //[Authorize]
    public class ListValueController : BaseController
    {
        private readonly ISender _sender;

        public ListValueController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("CreateNewListValue")]
        public async Task<IActionResult> CreateNewListValue(AddListValueCommand model)
        {
            var command = await _sender.Send(model);

            return base.OperationResult(command);
        }

        [HttpGet("GetAllListValues")]
        public async Task<IActionResult> GetAllListValues([FromQuery] PaginationParams paginationParams)
        {
            var query = await _sender.Send(new GetAllListValuesQuery(paginationParams));

            return base.OperationResult(query);
        }

        [HttpGet("GetListValueById/{id}")]
        public async Task<IActionResult> GetListValueById(int id)
        {
            var query = await _sender.Send(new GetByIdListValueQuery(id));

            return base.OperationResult(query);
        }

        [HttpPut("UpdateListValue")]
        public async Task<IActionResult> UpdateListValue(UpdateListValueCommand command)
        {
            var result = await _sender.Send(command);

            return base.OperationResult(result);
        }
    }
}