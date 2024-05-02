using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Impaye.Commands.AddImpayeCommand;

public record AddImpayeCommand(T_IMPAYE Impaye) : IRequest<OperationResult<bool>>;
