using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TJob.Commands.AddTJob;

public record AddTJobCommand(TR_ACTPROF_BCT actprofBct) :IRequest<OperationResult<bool>>;
