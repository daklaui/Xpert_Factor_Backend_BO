using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Queries.GetJobsList;

public record GetJobsListQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetJobsListQueryResult>>>;