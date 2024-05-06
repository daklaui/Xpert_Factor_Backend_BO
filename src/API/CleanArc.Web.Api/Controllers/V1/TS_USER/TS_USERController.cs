using CleanArc.Application.Common;
using CleanArc.Application.Features.TsUserAuth.Commands.AddTS_USERCommand;
/*using CleanArc.Application.Features.Users.Commands.UpdateUserCommand;
using CleanArc.Application.Features.Users.Queries.GetAllUsers;
using CleanArc.Application.Features.Users.Queries.GetUserById;*/
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Users
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/Users")]
    //[Authorize]
    public class UsersController : BaseController
    {
        private readonly ISender _sender;

        public UsersController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("CreateNewUser")]
        public async Task<IActionResult> CreateNewUser(AddUserCommand model)
        {
            var command = await _sender.Send(model);
            return base.OperationResult(command);
        }

        /*[HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers([FromQuery] PaginationParams paginationParams)
        {
            var query = await _sender.Send(new GetAllUsersQuery(paginationParams));
            return base.OperationResult(query);
        }

        [HttpGet("GetUserById/{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var query = await _sender.Send(new GetUserByIdQuery(id));
            return base.OperationResult(query);
        }

        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UpdateUserCommand command)
        {
            var result = await _sender.Send(command);
            return base.OperationResult(result);
        }*/
    }
}