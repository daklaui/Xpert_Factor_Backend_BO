using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.FraisDivers.Commands.AddFraisDiversCommand
{
    public record AddFraisDiversCommand(T_FRAIS_DIVERS FraisDivers) : IRequest<OperationResult<bool>>;
}
