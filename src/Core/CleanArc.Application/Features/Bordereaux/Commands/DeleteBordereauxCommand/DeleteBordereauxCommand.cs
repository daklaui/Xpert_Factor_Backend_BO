using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.DeleteBordereauxCommand;

public class DeleteBordereauxCommand : IRequest<OperationResult<bool>>
{
    public string BordereauId { get; set; }
}