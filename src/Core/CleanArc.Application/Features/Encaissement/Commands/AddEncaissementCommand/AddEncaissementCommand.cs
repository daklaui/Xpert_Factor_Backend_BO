using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Encaissement.Commands.AddEncaissementCommand;

public record AddEncaissementCommand(T_ENCAISSEMENT Encaissement): IRequest<OperationResult<bool>>;
