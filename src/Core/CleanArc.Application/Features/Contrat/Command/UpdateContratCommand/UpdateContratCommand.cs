using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Contrat.Commands.UpdateContratCommand
{
    public record UpdateContratCommand(T_CONTRAT Contrat) : IRequest<OperationResult<bool>>;
}
