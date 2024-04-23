using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.buyer.Commands.AddBuyer;

public record AddBuyerCommand(List<TJ_CIR> Buyer) : IRequest<OperationResult<bool>>;