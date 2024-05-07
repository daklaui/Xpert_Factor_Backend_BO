using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TjDocumentDetBord.Queries.GetById;

public record GetByIdQuery(int TjDocumentId) :IRequest<OperationResult<GetByIdQueryResult>>;
