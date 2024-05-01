using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Contrat.Commands.AddContratCommand
{
    public record AddContratCommand(ContractDTO Contrat) : IRequest<OperationResult<bool>>;
}
