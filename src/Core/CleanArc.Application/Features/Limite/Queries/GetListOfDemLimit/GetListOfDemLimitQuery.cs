using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Limite.Queries.GetListOfDemLimit;

public record GetListOfDemLimitQuery(PaginationParams paginationParams):IRequest<OperationResult<PageInfo<GetListOfDemLimitQueryResult>>>;
