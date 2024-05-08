using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.TJob.Commands.UpdateTJobCommand;

public record UpdateTJobsCommand(string code,TR_ACTPROF_BCT Bct):IRequest<OperationResult<bool>>;