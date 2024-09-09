
using CleanArc.Application.Models.Common;
using Mediator;


namespace CleanArc.Application.Features.Contact.Queries.GetIsContactBelongsToContract;

public record VerifContactExistsQuery(int contactId)
    : IRequest<OperationResult<VerifContactExistsQuery_Response>>;

