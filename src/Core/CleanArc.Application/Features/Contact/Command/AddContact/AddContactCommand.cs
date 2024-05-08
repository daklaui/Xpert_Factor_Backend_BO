using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Contact.Command;

public record AddContactCommand(T_CONTACT contact) : IRequest<OperationResult<bool>>;