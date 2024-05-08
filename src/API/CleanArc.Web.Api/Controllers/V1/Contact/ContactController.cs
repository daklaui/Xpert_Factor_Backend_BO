using CleanArc.Application.Common;
using CleanArc.Application.Features.Contact.Command;
using CleanArc.Application.Features.Contact.Command.UpdateContact;
using CleanArc.Application.Features.Contact.Queries.GetAllContacts;
using CleanArc.Application.Features.Contact.Queries.GetContactById;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Contact;
[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Contact")]
//[Authorize]
public class ContactController :BaseController
{
    private readonly ISender _sender;

    public ContactController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("CreateNewContact")]
    public async Task<IActionResult> CreateNewContact(AddContactCommand model)
    {
        var command = await _sender.Send(model);
        return base.OperationResult(command);
    }
    
    [HttpPut("UpdateContact/{id}")]
    public async Task<IActionResult> UpdateContact(int id, UpdateContactCommand model)
    {
        if (model == null)
        {
            return BadRequest("Invalid model");
        }
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    [HttpGet("GetContactById/{id}")]
    public async Task<IActionResult> GetContactById(int id)
    {
        var query = await _sender.Send(new GetContactByIdQuery(id));

        return base.OperationResult(query);
    }
    [HttpGet("GetAllContact")]
    public async Task<IActionResult> GetAllContacts([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllContactQuery(paginationParams));

        return base.OperationResult(query);
    }

 
}