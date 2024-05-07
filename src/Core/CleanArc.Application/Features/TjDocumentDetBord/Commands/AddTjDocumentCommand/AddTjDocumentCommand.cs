using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TjDocumentDetBord.Commands.AddTjDocumentCommand;

public record AddTjDocumentCommand(TJ_DOCUMENT_DET_BORD TjDocumentDetBord): IRequest<OperationResult<bool>>;