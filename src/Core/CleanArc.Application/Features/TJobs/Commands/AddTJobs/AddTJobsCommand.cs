using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TJobs.TJobs.Commands.AddTJobs
{
    public record AddTJobsCommand(Domain.Entities.TR_ACTPROF_BCT ActprofBct) : IRequest<OperationResult<bool>>;
}
