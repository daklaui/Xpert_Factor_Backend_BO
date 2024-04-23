using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TjDocumentDetBord.Queries.GetAllTjDocument;

public record GetAllTjDocumentQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetAllTjDocumentQueryResult>>>;