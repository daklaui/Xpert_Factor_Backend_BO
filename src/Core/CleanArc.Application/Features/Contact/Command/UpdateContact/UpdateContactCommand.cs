using CleanArc.Application.Models.Common;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Contact.Command.UpdateContact;

public record UpdateContactCommand(T_CONTACT Contact) : IRequest<OperationResult<bool>>;
