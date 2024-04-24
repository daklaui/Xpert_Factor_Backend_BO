using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Individu.Commands.AddContactCommand;

public record AddContactCommand(List<T_CONTACT> contacts) : IRequest<OperationResult<bool>>;