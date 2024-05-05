using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Litige.Commands.AddLitige;

public record AddLitigesCommand(T_LITIGE litige, decimal? MONT_LT) : IRequest<OperationResult<bool>>;
