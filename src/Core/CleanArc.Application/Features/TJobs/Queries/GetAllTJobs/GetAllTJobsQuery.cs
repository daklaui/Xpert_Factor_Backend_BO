using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TJobs.Queries.GetAllTJobs
{
    public record GetAllTJobsQuery(PaginationParams PaginationParams) : IRequest<OperationResult<PageInfo<GetAllTJobsQueryResult>>>;
}
