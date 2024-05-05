using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Litiges.Commands;

public record AddLitigesCommand(T_LITIGE litige, string MONT_LT) : IRequest<OperationResult<bool>>;
