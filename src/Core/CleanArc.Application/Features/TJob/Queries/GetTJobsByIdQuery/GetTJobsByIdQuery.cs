using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TJob.Queries.GetTJobsByIdQuery;

public record GetTJobsByIdQuery(String code) : IRequest<OperationResult<GetTJobsById_Response>>;
