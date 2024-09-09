using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Contact.Queries.ContactExistsTelQuery;

public record ContactExistsTelQuery(int RefIndiv, string PhoneNumber) : IRequest<OperationResult<bool>>;
