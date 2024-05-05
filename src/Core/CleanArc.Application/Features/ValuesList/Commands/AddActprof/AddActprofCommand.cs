using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Commands.AddActprof;

public record AddActprofCommand(TR_ACTPROF_BCT actprofBct) : IRequest<OperationResult<bool>>;