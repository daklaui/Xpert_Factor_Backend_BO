using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Limite.Commands.ValidateLimiteCommand;

public record ValidateLimiteCommand(int REF_DEM_LIM) : IRequest<OperationResult<bool>>;
