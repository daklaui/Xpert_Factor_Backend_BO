﻿using CleanArc.Application.Common;
using CleanArc.Application.Features.ListVal.Commands.AddValsCommand;
using CleanArc.Application.Features.ListVal.Commands.UpdateTListValCommand;
using CleanArc.Application.Features.ListVal.Queries.GetAllTListVals;
using CleanArc.Application.Features.ListVal.Queries.GetFormJuridique;
using CleanArc.Application.Features.ListVal.Queries.GetListValByType;
using CleanArc.Application.Features.ListVal.Queries.GetTListValById;
using CleanArc.Application.Features.Recouvrement.Queries.GetAllRecouvrements;
using CleanArc.WebFramework.BaseController;
using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.TListVal
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/TListVal")]
    public class TListValController : BaseController
    {
        private readonly ISender _sender;

        public TListValController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("CreateNewTListVal")]
        public async Task<IActionResult> CreateNewTListVal(AddTListValCommand model)
        {
            if (model == null)
            {
                return BadRequest("Invalid model");
            }

            var commandResult = await _sender.Send(model);

            if (commandResult == null || !commandResult.IsSuccess)
            {
                return BadRequest("Failed to create new TListVal");
            }

            return Ok("TListVal created successfully");
        }


        [HttpGet("GetAllTListVals")]
        public async Task<IActionResult> GetAllTListVals([FromQuery] PaginationParams paginationParams)
        {
            if (paginationParams == null)
            {
                return BadRequest("PaginationParams cannot be null.");
            }

            var query = await _sender.Send(new GetAllTListValsQuery(paginationParams));

            if (query == null)
            {
                return NotFound();
            }

            return base.OperationResult(query);
        }


        [HttpGet("GetAllTListValsByType")]
        public async Task<IActionResult> GetAllTListValsByType([FromQuery] string type)
        {
           

            var query = await _sender.Send(new GetListValByTypeQuery(type));

            if (query == null)
            {
                return NotFound();
            }

            return base.OperationResult(query);
        }


        [HttpGet("GetTListValById/{id}")]
        public async Task<IActionResult> GetTListValById(int id)
        {
            var query = await _sender.Send(new GetTListValByIdQuery(id));
            return base.OperationResult(query);
            
        }
        
        [HttpPut("UpdateTListVal/{id}")]
        public async Task<IActionResult> UpdateTListVal(int id, UpdateTListValCommand model)
        {
            if (model == null)
            {
                return BadRequest("Invalid model");
            }

            var command = await _sender.Send(model);

            return base.OperationResult(command);
        }
        
        [HttpGet("GetAllRecouvrement")]
        public async Task<IActionResult> GetListOfRecouvrement([FromQuery] PaginationParams paginationParams)
        {
            var query = await _sender.Send(new GetAllRecouvrementQuery(paginationParams));

            return base.OperationResult(query);
        }      
        
        
        [HttpGet("GetFormJuridique")]
        public async Task<IActionResult> GetFormJuridique()
        {
            var query = await _sender.Send(new GetFormJuridiqueQuery());

            return base.OperationResult(query);
        }

        
    }
}