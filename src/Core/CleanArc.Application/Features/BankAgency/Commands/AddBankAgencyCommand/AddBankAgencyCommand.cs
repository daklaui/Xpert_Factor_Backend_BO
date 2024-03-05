using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.BankAgency.Commands.AddBankAgencyCommand;

public record AddAgBqCommand(TRAgBq AgBq) : IRequest<OperationResult<bool>>;