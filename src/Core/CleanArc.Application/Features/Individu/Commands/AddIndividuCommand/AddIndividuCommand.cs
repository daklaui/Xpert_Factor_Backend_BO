using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Individu.Commands.AddIndividuCommand
{
    public record AddIndividuCommand(IndividualDTO IndividualDTO) : IRequest<OperationResult<bool>>;
}