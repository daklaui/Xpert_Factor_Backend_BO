using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TjDocumentDetBord.Commands.UpdateTjDocumentCommand;

public record UpdateTjDocumentCommand : IRequest<OperationResult<bool>>
{
    public PksTjDetBord TjDetBordToUpdate { get; set; }
    public TJ_DOCUMENT_DET_BORD UpdateTjDocumentDetBord { get; set; }
}