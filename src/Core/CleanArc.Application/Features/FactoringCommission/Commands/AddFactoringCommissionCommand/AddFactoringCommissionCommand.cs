using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.FactoringCommission.Commands.AddFactoringCommissionCommand
{
    public record AddFactoringCommissionCommand(T_COMM_FACTORING FactoringCommission) : IRequest<OperationResult<bool>>;
}
