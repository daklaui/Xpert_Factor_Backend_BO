using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Recouvrement.Commands.UpdateRecouvrementCommand;

public record UpdateRecouvrementCommand : IRequest<OperationResult<bool>>
{
    public int RecouvrementId { get; set; }
    public TR_LIST_VAL UpdatedRecouvrement { get; set; }
}