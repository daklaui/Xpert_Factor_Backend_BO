
using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TR_CP.Queries.GetAllTR_CP
{
    public record GetAllTR_CPQuery(PaginationParams paginationParams) : IRequest<OperationResult<PageInfo<GetAllTR_CPQueryResult>>>;
}