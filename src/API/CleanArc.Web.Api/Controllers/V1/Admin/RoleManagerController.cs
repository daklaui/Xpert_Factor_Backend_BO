﻿using System.ComponentModel.DataAnnotations;
using CleanArc.Application.Features.Role.Commands.AddRoleCommand;
using CleanArc.Application.Features.Role.Commands.UpdateRoleClaimsCommand;
using CleanArc.Application.Features.Role.Queries.GetAllRolesQuery;
using CleanArc.Application.Features.Role.Queries.GetAuthorizableRoutesQuery;
using CleanArc.Infrastructure.Identity.Identity.PermissionManager;
using CleanArc.WebFramework.BaseController;
using CleanArc.WebFramework.WebExtensions;
using Mediator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Admin
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/RoleManager")]
    [Authorize(ConstantPolicies.DynamicPermission)]
    [Display(Description = "Managing Related Roles for the System")]

    public class RoleManagerController : BaseController
    {
        private readonly ISender _sender;

        public RoleManagerController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet("Roles")]
        public async Task<IActionResult> GetRoles()
        {
            var queryResult = await _sender.Send(new GetAllRolesQuery());

            return base.OperationResult(queryResult);
        }

        [HttpGet("AuthRoutes")]
        public async Task<IActionResult> GetAuthRoutes()
        {
            var queryModel = await _sender.Send(new GetAuthorizableRoutesQuery());

            return base.OperationResult(queryModel);
        }

        /// <summary>
        /// Update a role permissions (claims) based on RouteKey received in AuthRoutes API
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("UpdateRolePermissions")]
        public async Task<IActionResult> UpdateRolePermissions(UpdateRoleClaimsCommand model)
        {
            var commandResult =
                await _sender.Send(new UpdateRoleClaimsCommand(model.RoleId, model.RoleClaimValue));

            return base.OperationResult(commandResult);
        }

        [HttpPost("NewRole")]
        public async Task<IActionResult> AddRole(AddRoleCommand model)
        {
            var commandResult = await _sender.Send(model);

            return base.OperationResult(commandResult);
        }

    }
}
