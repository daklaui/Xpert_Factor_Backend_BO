using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Contact.Queries.GetContactById;

public record GetContactByIdQuery(int id) : IRequest<OperationResult<GetContactByIdQuery_Response>>;
