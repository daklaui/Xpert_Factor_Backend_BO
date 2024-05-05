using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Queries.GetLangList;

public record GetLangListQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetLangListQueryResult>>>;
    