using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Financement.Commands.AddFinancementCommand;

public record AddFinancementCommand(T_FINANCEMENT Financement) : IRequest<OperationResult<bool>>;