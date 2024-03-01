using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TJobs.Queries.GetTJobsById
{
    public record GetTJobsByIdQuery(int TJobsId) : IRequest<OperationResult<GetTJobsByIdQueryResult>>;
}
