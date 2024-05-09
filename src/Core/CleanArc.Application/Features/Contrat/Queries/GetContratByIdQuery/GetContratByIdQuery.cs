using CleanArc.Application.Models.Common;
using Mediator;

namespace CleanArc.Application.Features.Contrat.Queries.GetContratByIdQuery
{
    public record GetContratByIdQuery(int contratId) : IRequest<OperationResult<GetContratByIdQueryResult>>;
}
