using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.ListVal.Queries.GetFormJuridique
{
    public record GetFormJuridiqueQuery() : IRequest<OperationResult<List<GetFormJuridiqueQueryResult>>>;
}

