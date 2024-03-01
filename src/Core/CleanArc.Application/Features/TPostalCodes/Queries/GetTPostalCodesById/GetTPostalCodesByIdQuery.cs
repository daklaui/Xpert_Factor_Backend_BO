using CleanArc.Application.Features.Individu.Queries.GetByIdQuery;
using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.TPostalCodes.Queries.GetTPostalCodesById
{
    public record GetTPostalCodesByIdQuery(int TPostalCodesId) : IRequest<OperationResult<GetByIdQueryResult>>;
}
