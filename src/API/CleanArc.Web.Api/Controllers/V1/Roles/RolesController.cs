using CleanArc.Application.Features.Roles.Commands.AddRoleCommand;
using CleanArc.Application.Models.Common;
using Mediator;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CleanArc.Domain.Entities.User;

namespace CleanArc.API.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/Roles")]
    public class RolesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RolesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateNewRole")]
        public async Task<IActionResult> AddRole([FromBody] ROLES role)
        {
            var command = new AddRoleCommand(role);
            var result = await _mediator.Send(command);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result.ErrorMessage);
        }

        /*[HttpPut("{roleId}")]
        public async Task<IActionResult> UpdateRole(int roleId, [FromBody] string newRoleName)
        {
            var command = new UpdateRoleCommand(roleId, newRoleName);
            var result = await _mediator.Send(command);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result.ErrorMessage);
        }*/

        // Ajoutez d'autres actions pour gérer les requêtes et commandes liées aux rôles
    }
}