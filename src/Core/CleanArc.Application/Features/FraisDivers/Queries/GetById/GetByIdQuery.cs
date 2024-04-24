using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.FraisDivers.Queries.GetByIdQuery
{
    public record GetByIdFraisDiversQuery(int fraisDiversId) : IRequest<OperationResult<GetByIdFraisDiversQueryResult>>;
}