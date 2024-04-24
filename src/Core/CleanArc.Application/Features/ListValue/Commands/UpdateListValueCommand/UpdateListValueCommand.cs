using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ListValue.Commands.UpdateListValueCommand
{
    public record UpdateListValueCommand(TR_LIST_VAL ListValue) : IRequest<OperationResult<bool>>;
}
