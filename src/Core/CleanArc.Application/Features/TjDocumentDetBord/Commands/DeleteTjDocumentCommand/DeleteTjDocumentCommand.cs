using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TjDocumentDetBord.Commands.DeleteTjDocumentCommand;

public class DeleteTjDocumentCommand : IRequest<OperationResult<bool>>
{ 
    public int TjDocumentId { get; set; }
}