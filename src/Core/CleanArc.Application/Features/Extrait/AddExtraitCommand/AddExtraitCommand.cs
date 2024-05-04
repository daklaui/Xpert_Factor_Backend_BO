using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Extrait.AddExtraitCommand;

public record AddExtraitCommand(T_EXTRAIT Extrait) : IRequest<OperationResult<bool>>;