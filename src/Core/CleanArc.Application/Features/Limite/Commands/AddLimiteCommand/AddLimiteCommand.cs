using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Limite.Commands.AddLimiteCommand;

public record AddLimiteCommand(T_DEM_LIMITE Limite) : IRequest<OperationResult<bool>>;
