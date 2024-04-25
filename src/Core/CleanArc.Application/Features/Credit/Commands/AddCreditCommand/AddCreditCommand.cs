using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;
namespace CleanArc.Application.Features.Credit.Commands.AddCreditCommand;

public record AddCreditCommand(T_MVT_CREDIT Credit) : IRequest<OperationResult<bool>>;