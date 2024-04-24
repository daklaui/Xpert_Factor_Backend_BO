using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TR_CP.Commands.UpdateTR_CPCommand
{
    public record UpdateTR_CPCommand(Domain.Entities.TR_CP TR_CP) : IRequest<OperationResult<bool>>;
}
