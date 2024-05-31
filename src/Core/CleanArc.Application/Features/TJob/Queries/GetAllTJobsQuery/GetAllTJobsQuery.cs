using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TJob.Queries.GetAllTJobs;

public record GetAllTJobsQuery : IRequest<OperationResult<List<GetAllTJobsQuery_Response>>>;
