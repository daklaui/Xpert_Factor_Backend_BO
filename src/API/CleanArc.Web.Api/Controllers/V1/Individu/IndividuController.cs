﻿using CleanArc.Application.Common;
using CleanArc.Application.Features.AgencyBank.Queries.GetAgnecyBankByIdQuerie;
using CleanArc.Application.Features.Individu.Commands.AddIndividuCommand;
using CleanArc.Application.Features.Individu.Queries.GetAllIndividus;
using CleanArc.Application.Features.Individu.Queries.GetByIdQuery;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Individu;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/Individu")]
//[Authorize]
public class IndividuController : BaseController
{
    private readonly ISender _sender;

    public IndividuController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("CreateNewIndividu")]
    public async Task<IActionResult> CreateNewIndividu(AddIndividuCommand model)
    {
    
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }

   [HttpGet("GetAllIndividus")]
    public async Task<IActionResult> GetAllIndividus([FromQuery] PaginationParams paginationParams)
    {
        var query = await _sender.Send(new GetAllIndividusQuery(paginationParams));

        return base.OperationResult(query);
    }

    [HttpGet("GetIndividuById/{id}")]
    public async Task<IActionResult> GetIndividuById(string id)
    {
        var query = await _sender.Send(new GetAgencyBankByIdQuery(id));

        return base.OperationResult(query);
    }
    
    
}