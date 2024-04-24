using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.FactoringCommission.Commands.UpdateFactoringCommissionCommand
{
    public record UpdateFactoringCommissionCommand(T_COMM_FACTORING FactoringCommission) : IRequest<OperationResult<bool>>;
}
