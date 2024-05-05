using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Queries.GetPostsList;

public record GetPostsListQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetPostsListQueryResult>>>;
