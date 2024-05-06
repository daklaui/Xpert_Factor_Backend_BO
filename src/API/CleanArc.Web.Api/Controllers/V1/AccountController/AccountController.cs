using CleanArc.Application.Common;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Account
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/Account")]
    //[Authorize]
    public class AccountController : BaseController
    {
        private readonly ISender _sender;

        public AccountController(ISender sender)
        {
            _sender = sender;
        }

        /*[HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
        {
            var result = await _sender.Send(command);
            return base.OperationResult(result);
        }*/

    }
}