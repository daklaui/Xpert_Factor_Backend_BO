using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.UpdateBordereauxCommand;

public record UpdateBordereauxCommand : IRequest<OperationResult<bool>>
{
    public BordereauDTO BordereauToUpdate { get; set; }
    public List<TJ_DOCUMENT_DET_BORD> UpdatedDocuments { get; set; } 
}
