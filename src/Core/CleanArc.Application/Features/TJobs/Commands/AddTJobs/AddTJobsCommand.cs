using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TJobs.TJobs.Commands.AddTJobs
{
    public record AddTJobsCommand(Domain.Entities.TJobs TJobs) : IRequest<OperationResult<bool>>;
}
