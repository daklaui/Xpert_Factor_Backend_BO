using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Contact.Queries.ContactExistsTelQuery;

public record ContactExistsPositionQuery(int refIndiv, int position) : IRequest<OperationResult<bool>>;
