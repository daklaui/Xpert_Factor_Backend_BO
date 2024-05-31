using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using MediatR;

namespace CleanArc.Application.Features.buyer.Commands.AddBuyerLimit;

public record AddBuyerLimitCommmand(BuyerDTO Buyer) : IRequest<OperationResult<bool>>, global::Mediator.IRequest<OperationResult<bool>>;
