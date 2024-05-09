using CleanArc.Application.Common;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.FraisDivers.Queries.GetAllFraisDivers
{
    public record GetAllFraisDiversQuery(PaginationParams paginationParams) : IRequest<OperationResult<PageInfo<GetAllFraisDiversQueryResult>>>;
}