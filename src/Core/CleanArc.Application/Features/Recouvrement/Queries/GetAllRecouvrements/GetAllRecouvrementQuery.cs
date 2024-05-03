using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Recouvrement.Queries.GetAllRecouvrements;

public record GetAllRecouvrementQuery(PaginationParams paginationParams) :IRequest<OperationResult<PageInfo<GetAllRecouvrementQueryResult>>>;