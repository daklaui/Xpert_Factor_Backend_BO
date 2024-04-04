using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Bordereaux.Commands.AddBordereauxCommand;

public record AddBordereauxCommand(T_BORDEREAU Bordereau): IRequest<OperationResult<bool>>;