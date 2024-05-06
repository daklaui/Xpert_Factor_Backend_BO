using CleanArc.Application.Common;
using CleanArc.Application.Features.Permissions.Commands.AddPermissionCommand;
/*using CleanArc.Application.Features.Permissions.Commands.UpdatePermissionCommand;
using CleanArc.Application.Features.Permissions.Queries.GetAllPermissions;
using CleanArc.Application.Features.Permissions.Queries.GetPermissionById;*/
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Permissions
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/Permissions")]
    //[Authorize]
    public class PermissionsController : BaseController
    {
        private readonly ISender _sender;

        public PermissionsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("CreateNewPermission")]
        public async Task<IActionResult> CreateNewPermission(AddPermissionCommand model)
        {
            var command = await _sender.Send(model);
            return base.OperationResult(command);
        }
/*
        [HttpGet("GetAllPermissions")]
        public async Task<IActionResult> GetAllPermissions([FromQuery] PaginationParams paginationParams)
        {
            var query = await _sender.Send(new GetAllPermissionsQuery(paginationParams));
            return base.OperationResult(query);
        }

        [HttpGet("GetPermissionById/{id}")]
        public async Task<IActionResult> GetPermissionById(int id)
        {
            var query = await _sender.Send(new GetPermissionByIdQuery(id));
            return base.OperationResult(query);
        }

        [HttpPut("UpdatePermission")]
        public async Task<IActionResult> UpdatePermission(UpdatePermissionCommand command)
        {
            var result = await _sender.Send(command);
            return base.OperationResult(result);
        }*/
    }
}