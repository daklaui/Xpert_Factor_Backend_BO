using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Queries.GetFromJuridiqueList;

public record GetFromJuridiqueListQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetFromJuridiqueListQueryResult>>>;