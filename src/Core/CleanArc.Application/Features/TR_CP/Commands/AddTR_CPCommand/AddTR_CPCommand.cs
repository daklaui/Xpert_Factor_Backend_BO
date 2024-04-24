using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TR_CP.Commands.AddTR_CPCommand
{
    public record AddTR_CPCommand(Domain.Entities.TR_CP TR_CP) : IRequest<OperationResult<bool>>;
}
