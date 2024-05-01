using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Contrat.Commands.UpdateContratCommand
{
    public record UpdateContratCommand(ContractDTO Contrat) : IRequest<OperationResult<bool>>;
}
