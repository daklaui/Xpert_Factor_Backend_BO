using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.buyer.Commands.AddBuyer;

public record AddBuyerCommand(BuyerDTO Buyer) : IRequest<OperationResult<bool>>;
