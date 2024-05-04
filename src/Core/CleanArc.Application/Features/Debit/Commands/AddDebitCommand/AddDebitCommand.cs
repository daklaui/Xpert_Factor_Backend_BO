using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;
namespace CleanArc.Application.Features.Debit.Commands.AddDebitCommand;

public record AddDebitCommand(T_MVT_DEBIT Debit) : IRequest<OperationResult<bool>>;
