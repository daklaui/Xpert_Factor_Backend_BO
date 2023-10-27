﻿using CleanArc.Application.Features.Order.Commands;
using CleanArc.Application.Features.Order.Queries.GetUserOrders;
using CleanArc.WebFramework.BaseController;
using CleanArc.WebFramework.WebExtensions;
using Mediator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Web.Api.Controllers.V1.Order;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/User")]
[Authorize]
public class OrderController : BaseController
{
    private readonly ISender _sender;

    public OrderController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("CreateNewOrder")]
    public async Task<IActionResult> CreateNewOrder(AddOrderCommand model)
    {
        model.UserId = base.UserId;
        var command = await _sender.Send(model);

        return base.OperationResult(command);
    }

    [HttpGet("GetUserOrders")]
    public async Task<IActionResult> GetUserOrders()
    {
        var query = await _sender.Send(new GetUserOrdersQueryModel(UserId));

        return base.OperationResult(query);
    }
}