using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Contact.Queries.GetAllContacts;

public record GetAllContactQuery(PaginationParams PaginationParams):IRequest<OperationResult<PageInfo<GetAllContactsQuery_Response>>>;
