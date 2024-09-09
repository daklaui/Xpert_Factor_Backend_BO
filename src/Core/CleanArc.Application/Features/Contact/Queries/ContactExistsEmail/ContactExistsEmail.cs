using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Contact.Queries.ContactExistsTelQuery;

public record ContactExistsEmailQuery(int RefIndiv, string email) : IRequest<OperationResult<bool>>;
