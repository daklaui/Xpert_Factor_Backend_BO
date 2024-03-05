using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TMM.Queries.GetAllTmmQueries;

public record GetAllTmmQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetAllTmmQueryResult>>>;
