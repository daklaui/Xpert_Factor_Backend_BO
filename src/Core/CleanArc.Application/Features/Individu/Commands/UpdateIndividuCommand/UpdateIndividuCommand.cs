using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Individu.Commands.UpdateIndividuCommand
{
    public record UpdateIndividuCommand(IndividualDTO IndividualDTO) : IRequest<OperationResult<bool>>;
}
