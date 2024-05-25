 
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Individu.Queries.GetByIdQuery
{
    public record GetByIdQuery(int IndividuId) : IRequest<OperationResult<GetByIdQueryResult>>;
}