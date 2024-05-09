using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.FraisDivers.Queries.GetByIdQuery
{
    public record GetByIdFraisDiversQuery(int fraisDiversId , string fraisDiversType) : IRequest<OperationResult<GetByIdFraisDiversQueryResult>>;
}