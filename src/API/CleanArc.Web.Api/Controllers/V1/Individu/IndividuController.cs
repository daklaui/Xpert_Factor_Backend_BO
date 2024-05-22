﻿using CleanArc.Application.Common;
using CleanArc.Application.Features.Individu.Commands.AddIndividuCommand;
using CleanArc.Application.Features.Individu.Commands.UpdateIndividuCommand;
using CleanArc.Application.Features.Individu.Queries.GetAllAdherents;
using CleanArc.Application.Features.Individu.Queries.GetAllIndividus;
using CleanArc.Application.Features.Individu.Queries.GetByIdQuery;
using CleanArc.Application.Features.Individu.Queries.GetRefCtrCirByAdherentName;
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
    public async Task<IActionResult> GetIndividuById(int id)
    {
        var query = await _sender.Send(new GetByIdQuery(id));

        return base.OperationResult(query);
    }
    
    [HttpPut("UpdateIndividu/{id}")]
    public async Task<IActionResult> UpdateJob(int id, UpdateIndividuCommand model)
    {
        if (model == null)
        {
            return BadRequest("Invalid model");
        }
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }
    [HttpGet("GetAllAdherents")]
    public async Task<IActionResult> GetAllAdherents()
    {
        var query = new GetAllAdherentsQuery();
        var result = await _sender.Send(query);
        Console.WriteLine($"OperationResult Success: {result.IsSuccess}");
        return base.OperationResult(result);
    }
        
    [HttpGet("GetRefCtrCirByRefInd/{refInd}")]
    public async Task<IActionResult> GetRefCtrCirByRefInd(int refInd)
    {
        var query = new GetRefCtrCirByRefIndQuery(refInd);
        var result = await _sender.Send(query);
        return base.OperationResult(result);
    }
    

}