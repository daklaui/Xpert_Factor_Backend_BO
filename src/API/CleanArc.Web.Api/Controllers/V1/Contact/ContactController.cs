using CleanArc.Application.Common;
using CleanArc.Application.Features.Contact.Command;
using CleanArc.Application.Features.Contact.Command.UpdateContact;
using CleanArc.Application.Features.Contact.Queries.ContactExistsTelQuery;
using CleanArc.Application.Features.Contact.Queries.GetAllContacts;
using CleanArc.Application.Features.Contact.Queries.GetContactById;
using CleanArc.Application.Features.Contact.Queries.GetIsContactBelongsToContract;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Contact;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Contact")]
//[Authorize]
public class ContactController : BaseController
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

    [HttpPut("UpdateContact")]
    public async Task<IActionResult> UpdateContact(UpdateContactCommand model)
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

    [HttpGet("VerifContactExists/{contactId}")]
    public async Task<IActionResult> VerifContactExists(int contactId)
    {
        if (contactId <= 0)
        {
            return BadRequest("Invalid parameters");
        }

        var query = await _sender.Send(new VerifContactExistsQuery(contactId));
        return base.OperationResult(query);
    }


    [HttpGet("ContactExistsTel")]
    public async Task<IActionResult> ContactExistsTel(int refIndiv, string phoneNumber)
    {
        var result = await _sender.Send(new ContactExistsTelQuery(refIndiv, phoneNumber));

        if (result.IsSuccess)
        {
            return Ok(result.Data);
        }
        else
        {
            return NotFound(result.ErrorMessage);
        }
    }
    [HttpGet("ContactExistsEmail")]
    public async Task<IActionResult> ContactExistsEmail(int refIndiv, string email)
    {
        var result = await _sender.Send(new ContactExistsEmailQuery(refIndiv, email));

        if (result.IsSuccess)
        {
            return Ok(result.Data);
        }
        else
        {
            return NotFound(result.ErrorMessage);
        }
    }
    [HttpGet("ContactExistsPosition")]
    public async Task<IActionResult> ContactPositionPosition(int refIndiv, int position)
    {
        var result = await _sender.Send(new ContactExistsPositionQuery(refIndiv, position));

        if (result.IsSuccess)
        {
            return Ok(result.Data);
        }
        else
        {
            return NotFound(result.ErrorMessage);
        }
    }
}