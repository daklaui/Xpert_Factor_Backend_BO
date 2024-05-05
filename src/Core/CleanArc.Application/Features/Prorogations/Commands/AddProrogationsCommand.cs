using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Prorogations.Commands;

public record AddProrogationsCommand(T_PROROGATION prorogation): IRequest<OperationResult<bool>>;
