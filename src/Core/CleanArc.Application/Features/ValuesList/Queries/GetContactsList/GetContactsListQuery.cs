using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ValuesList.Queries.GetContactsList;

public record GetContactsListQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetContactsListQueryResult>>>;