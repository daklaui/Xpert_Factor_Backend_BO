using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.DeleteBordereauxCommand;

public class DeleteBordereauxCommand : IRequest<OperationResult<bool>>
{
    public PksBordereauxDto BordereauToDelete { get; set; }
}